using E_Spożywczak.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ProductCategories = _context.ProductCategory.ToList();

            List<Models.Product> products;
            if (id != null)
                products = await _context.Product.Where(x => x.ProductCategoryId == id).ToListAsync();
            else
                products = await _context.Product.ToListAsync();

            return View("Index", products);
        }
    }
}
