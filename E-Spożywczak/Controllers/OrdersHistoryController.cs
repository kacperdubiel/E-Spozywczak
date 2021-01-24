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
    public class OrdersHistoryController : Controller
    {
        private readonly DatabaseContext _context;

        public OrdersHistoryController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            OrdersHistory ordersHistory = _context.OrdersHistory.Include("Orders.Cart.ProductsInCart.Product").FirstOrDefault((x => x.Id == _context.GetCurrentOrdersHistoryId()));
            List<Order> ordersInHistory = ordersHistory.Orders.OrderByDescending(o => o.OrderDate).ToList();
            return View("Index", ordersInHistory);
        }
    }
}
