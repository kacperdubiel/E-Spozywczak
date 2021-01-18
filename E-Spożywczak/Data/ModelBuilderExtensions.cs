using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Spożywczak.Models;

namespace E_Spożywczak.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory()
                {
                    Id = 1,
                    Name = "Słodycze"
                },
                new ProductCategory()
                {
                    Id = 2,
                    Name = "Owoce"
                },
                new ProductCategory()
                {
                    Id = 3,
                    Name = "Pieczywo"
                },
                new ProductCategory()
                {
                    Id = 4,
                    Name = "Makarony"
                },
                new ProductCategory()
                {
                    Id = 5,
                    Name = "Sery"
                },
                new ProductCategory()
                {
                    Id = 6,
                    Name = "Sosy"
                }
                ); ;
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Baton Mars",
                    MeasureType = MeasureType.Piece,
                    Price = 2.30M,
                    Availability = 50,
                    IsAvailable = true,
                    ImagePath = "baton_mars.jpg",
                    ProductCategoryId = 1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Baton MilkyWay",
                    MeasureType = MeasureType.Piece,
                    Price = 1.90M,
                    Availability = 60,
                    IsAvailable = true,
                    ImagePath = "milky_way.jpg",
                    ProductCategoryId = 1,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Baton Snickers",
                    MeasureType = MeasureType.Piece,
                    Price = 2.10M,
                    Availability = 70,
                    IsAvailable = true,
                    ImagePath = "baton_snickers.jpg",
                    ProductCategoryId = 1,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Jabłko Gala",
                    MeasureType = MeasureType.Kilogram,
                    Price = 3.62M,
                    Availability = 40,
                    IsAvailable = true,
                    ImagePath = "jablko.jpg",
                    ProductCategoryId = 2,
                },
                new Product()
                {
                    Id = 5,
                    Name = "Sos Bolognese",
                    MeasureType = MeasureType.Kilogram,
                    Price = 5.30M,
                    Availability = 40,
                    IsAvailable = true,
                    ImagePath = "sos_bolognese.jpg",
                    ProductCategoryId = 6,
                }
                ); ;
            modelBuilder.Entity<Rating>().HasData(
                new Rating()
                {
                    Id = 1,
                    Rate = 4,
                    RatingDate = DateTime.Today,
                    Message = "Bardzo dobre jabłka!",
                    ProductId=2
                },
                new Rating()
                {
                    Id = 2,
                    Rate = 1,
                    RatingDate = DateTime.Today,
                    Message = "Baton przeterminowany.",
                    ProductId = 1
                }
                ); ;
        }
    }
}
