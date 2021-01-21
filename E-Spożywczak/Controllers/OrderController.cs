using E_Spożywczak.Data;
using E_Spożywczak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Controllers
{
    public class OrderController : Controller
    {
        private readonly DatabaseContext _context;

        public OrderController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(IList<double> productamount)
        {
            Cart cart = _context.Cart.Include("ProductsInCart.Product").FirstOrDefault(x => x.Id == _context.GetCurrentCartId());

            if (cart.ProductsInCart.Count == 0 || productamount.Count != cart.ProductsInCart.Count)
            {
                TempData["msg_text"] = "Dodaj najpierw produkty do koszyka!";
                TempData["success_msg"] = false;
                TempData["msg_time"] = 2000;
                return RedirectToAction("Index", "Cart");
            }

            cart.TotalPrice = 0M;
            for (int i = 0; i < cart.ProductsInCart.Count; i++)
            {
                cart.ProductsInCart[i].ProductAmount = productamount[i];
                cart.ProductsInCart[i].TotalPrice = (decimal)cart.ProductsInCart[i].ProductAmount * cart.ProductsInCart[i].Product.Price;
                cart.TotalPrice += cart.ProductsInCart[i].TotalPrice;
            }

            ViewBag.Delivery = _context.Delivery.ToList();
            ViewBag.Payment = (TypeOfPayment[])Enum.GetValues(typeof(TypeOfPayment));

            _context.SaveChanges();
            return View(cart);
        }

        public IActionResult Order()
        {
            
            _context.SaveChanges();
            return View();
        }
    }
}
