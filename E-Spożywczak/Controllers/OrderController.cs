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

        public IActionResult Order(IList<string> address, int delivery_type, int payment_type, int cartid)
        {
            Cart cart = _context.Cart.Include("ProductsInCart.Product").FirstOrDefault(x => x.Id == cartid);

            if (cart == null || cart.ProductsInCart.Count == 0 || address.Count != 4)
            {
                return View("OrderFailure");
            }

            // Check whether products are available
            foreach (ProductInCart productInCart in cart.ProductsInCart)
            {
                if (productInCart.ProductAmount > productInCart.Product.Availability)
                {
                    var field = productInCart.Product.MeasureType.GetType().GetField(productInCart.Product.MeasureType.ToString());
                    var mesuretype = field.GetCustomAttribute<DisplayAttribute>().Name;

                    TempData["msg_text"] = $"Próbujesz zamówić {productInCart.ProductAmount} {mesuretype} " +
                        $"produktu o nazwie \"{productInCart.Product.Name}\"" +
                        $"\nStan magazynu: {productInCart.Product.Availability} {mesuretype}";
                    TempData["success_msg"] = false;
                    return View("OrderFailure");
                }
            }

            // Subtract bought product amount
            foreach (ProductInCart productInCart in cart.ProductsInCart)
            {
                productInCart.Product.Availability -= productInCart.ProductAmount;
            }

            string delivery_address = address[0] + ", " + address[1] + " " + address[2] + ", " + address[3];
            bool isOrderPaid = false;
            DateTime orderPaymentDate = new DateTime();

            if (payment_type == 0)
            {
                isOrderPaid = true;
                orderPaymentDate = DateTime.Now;
            }

            Order new_order = new Order()
            {
                DeliveryAddress = delivery_address,
                OrderDate = DateTime.Now,
                TypeOfPayment = (TypeOfPayment)payment_type,
                IsOrderPaid = isOrderPaid,
                OrderPaymentDate = orderPaymentDate,
                DeliveryId = delivery_type,
                CartId = cartid,
                OrdersHistoryId = _context.GetCurrentOrdersHistoryId()
            };

            Cart new_cart = new Cart();

            _context.Add(new_order);
            _context.Add(new_cart);
            _context.SaveChanges();

            if (payment_type == 0)
                return View("OrderRedirect");
            else
                return View("OrderSuccess");
        }

        public IActionResult OrderFailure()
        {
            return View("OrderFailure");
        }

        public IActionResult OrderRedirect()
        {
            return View("OrderRedirect");
        }

        public IActionResult OrderSuccess()
        {
            return View("OrderSuccess");
        }
    }
}
