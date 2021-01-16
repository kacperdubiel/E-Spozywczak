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
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
             
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
            /*modelBuilder.Entity<Cart>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Delivery>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Order>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<OrdersHistory>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Product>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<ProductInCart>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Rating>()
                .HasKey(t => t.Id);*/


            //modelBuilder.Seed();
        }
    }
}
