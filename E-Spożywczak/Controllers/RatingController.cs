using E_Spożywczak.Data;
using E_Spożywczak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace E_Spożywczak.Controllers
{
    public class RatingController : Controller
    {
        private readonly DatabaseContext _context;

        public RatingController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var product = _context.Product
                .Include(a => a.ProductCategory)
                .FirstOrDefault(m => m.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Rate(int? id, int rating, string message)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =_context.Product
                .Include(a => a.ProductCategory)
                .FirstOrDefault(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            Rating newRating = new Rating()
            {
                Rate = rating,
                Message = message,
                RatingDate = DateTime.Now,
                ProductId = (int)id,
                Product = product
            };

            _context.Add(newRating);
            _context.SaveChanges();

            return View("Index", product);
        }
    }
}
