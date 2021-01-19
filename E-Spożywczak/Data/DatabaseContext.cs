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
        public int CurrentCartId { get; set; }
        public int CurrentOrdersHistoryId { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            CurrentCartId = 1;
            CurrentOrdersHistoryId = 1;
        }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrdersHistory> OrderHistory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductInCart> ProductInCart { get; set; }
        public DbSet<Rating> Rating { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
