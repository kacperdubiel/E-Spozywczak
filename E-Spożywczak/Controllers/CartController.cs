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

        public async Task<IActionResult> Index()
        {

            Models.Cart cart = await _context.Cart.FindAsync(_context.CurrentCartId);

            List<Models.ProductInCart> productsInCart = new List<Models.ProductInCart>();

            if (cart != null)
                productsInCart = cart.ProductsInCart.ToList();

            return View("Index", productsInCart);
        }
    }
}
