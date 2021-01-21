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

            // To to w ogole najlepiej wywalić bo jak ktoś zmieni ilość rzeczy w koszyku to rip. może jakoś JSem wyliczyć idk
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
        public async Task<IActionResult> AddToCart(int productid, int categoryid, string searchbox, string sortby)
        {
            Models.Product product = await _context.Product.FindAsync(productid);

            if (product != null)
            {
                Models.ProductInCart productInCart = new Models.ProductInCart()
                {
                    ProductAmount = 1,
                    TotalPrice = product.Price,
                    ProductId = productid,
                    CartId = _context.GetCurrentCartId()
                };


                _context.Add(productInCart);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Filter", "Products", new { categoryid, searchbox, sortby }); 
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
    }
}
