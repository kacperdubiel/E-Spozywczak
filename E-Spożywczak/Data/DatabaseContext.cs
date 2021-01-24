using E_Spożywczak.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrdersHistory> OrdersHistory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductInCart> ProductInCart { get; set; }
        public DbSet<Rating> Rating { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public int GetCurrentCartId()
        {
            var currentCart = Cart.OrderByDescending(c => c.Id).FirstOrDefault();
            return currentCart.Id;
        }

        public int GetCurrentOrdersHistoryId()
        {
            var currentOrdersHistory = OrdersHistory.OrderByDescending(c => c.Id).FirstOrDefault();
            return currentOrdersHistory.Id;
        }
    }
}
