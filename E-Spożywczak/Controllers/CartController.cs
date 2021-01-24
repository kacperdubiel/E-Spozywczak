using E_Spożywczak.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Controllers
{
    public class CartController : Controller
    {
        private readonly DatabaseContext _context;

        public CartController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Models.Cart cart = _context.Cart.Include("ProductsInCart.Product").FirstOrDefault(x => x.Id == _context.GetCurrentCartId());

            List <Models.ProductInCart> productsInCart = new List<Models.ProductInCart>();

            if (cart != null)
                productsInCart = cart.ProductsInCart.ToList();

            if (productsInCart.Count == 0)
                return View("EmptyCart");

            decimal totalCartPrice = 0M;
            foreach (Models.ProductInCart productInCart in productsInCart)
            {
                productInCart.TotalPrice = (decimal)productInCart.ProductAmount * productInCart.Product.Price;
                totalCartPrice += productInCart.TotalPrice;
            }

            ViewBag.TotalCartPrice = totalCartPrice;
            return View("Index", productsInCart);
        }

        // GET: Articles/Create
        public async Task<IActionResult> AddToCart(int productid, int categoryid, string searchbox, string sortby, bool fromhistory)
        {
            Models.Product product = await _context.Product.FindAsync(productid);

            if (product != null)
            {
                int currentCartId = _context.GetCurrentCartId();
                Models.ProductInCart productInCart = new Models.ProductInCart()
                {
                    ProductAmount = 1,
                    TotalPrice = product.Price,
                    ProductId = productid,
                    CartId = currentCartId
                };

                var productInCartEx = await _context.ProductInCart.Select(p => p).FirstOrDefaultAsync(p => p.ProductId == productid && p.CartId == currentCartId);
                if (productInCartEx != null)
                {
                    productInCartEx.ProductAmount++;
                    productInCartEx.TotalPrice+=product.Price;
                }
                else
                {
                    _context.Add(productInCart);
                }
                await _context.SaveChangesAsync();

                TempData["msg_text"] = "Dodano produkt do koszyka!";
                TempData["success_msg"] = true;
                TempData["msg_time"] = 2000;
            }
            else
            {
                TempData["msg_text"] = "Produkt nie istnieje!";
                TempData["success_msg"] = false;
                TempData["msg_time"] = 2000;
            }

            if (!fromhistory)
                return RedirectToAction("Filter", "Products", new { categoryid, searchbox, sortby });
            else
                return RedirectToAction("Index", "OrdersHistory");
        }

        // GET
        public async Task<IActionResult> DeleteFromCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInCart = await _context.ProductInCart.Include("Product")
                .FirstOrDefaultAsync(p => p.Id == id);

            if (productInCart == null)
            {
                return NotFound();
            }

            return View(productInCart);
        }

        // POST
        [HttpPost, ActionName("DeleteFromCart")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFromCartConfirmed(int id)
        {
            var productInCart = await _context.ProductInCart.FindAsync(id);
            _context.ProductInCart.Remove(productInCart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateQuantity(int id, double quantity)
        {
            var productInCart = _context.ProductInCart.Include("Product").FirstOrDefault(x => x.Id == id);

            if (productInCart.Product.MeasureType == Models.MeasureType.Piece)
                quantity = Math.Round(quantity);

            if (quantity < 0)
                quantity = -quantity;

            if (quantity == 0)
            {
                if (productInCart.Product.MeasureType == Models.MeasureType.Piece)
                    quantity = 1;
                else
                    quantity = 0.1;
            }

            if (quantity > productInCart.Product.Availability)
                quantity = productInCart.Product.Availability;

            productInCart.ProductAmount = quantity;
            productInCart.TotalPrice = productInCart.Product.Price * (decimal)quantity;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
