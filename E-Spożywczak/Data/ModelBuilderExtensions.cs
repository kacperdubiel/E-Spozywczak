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
                    Name = "Nabiał"
                },
                new ProductCategory()
                {
                    Id = 5,
                    Name = "Mięso"
                },
                new ProductCategory()
                {
                    Id = 6,
                    Name = "Soki"
                }
                ); ;

            modelBuilder.Entity<Product>().HasData(
                //SLODYCZE///////////////////////////////////////////////////////
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
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
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
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
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
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 4,
                    Name = "Żelki haribo",
                    MeasureType = MeasureType.Piece,
                    Price = 5.10M,
                    Availability = 120,
                    IsAvailable = true,
                    ImagePath = "zelki_haribo.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 5,
                    Name = "Czekolada Milka",
                    MeasureType = MeasureType.Piece,
                    Price = 4.10M,
                    Availability = 10,
                    IsAvailable = true,
                    ImagePath = "czekolada_milka.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 6,
                    Name = "Czekolada Wedel",
                    MeasureType = MeasureType.Piece,
                    Price = 3.90M,
                    Availability = 1,
                    IsAvailable = true,
                    ImagePath = "czekolada_wedel.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 7,
                    Name = "Cukierki Skittles",
                    MeasureType = MeasureType.Piece,
                    Price = 4.50M,
                    Availability = 43,
                    IsAvailable = true,
                    ImagePath = "cukierki_skittles.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 8,
                    Name = "Pianki Haribo",
                    MeasureType = MeasureType.Piece,
                    Price = 6.50M,
                    Availability = 49,
                    IsAvailable = true,
                    ImagePath = "pianki_haribo.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 30,
                    Name = "Ciastka delicje",
                    MeasureType = MeasureType.Piece,
                    Price = 2.50M,
                    Availability = 11,
                    IsAvailable = true,
                    ImagePath = "ciastka_delicje.jpg",
                    ProductCategoryId = 1,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                ////////////////////////////////////////////////////////////////////////
                //OWOCE/////////////////////////////////////////////////////////////////
                new Product()
                {
                    Id = 9,
                    Name = "Jabłko Gala",
                    MeasureType = MeasureType.Kilogram,
                    Price = 3.62M,
                    Availability = 40,
                    IsAvailable = true,
                    ImagePath = "jablko.jpg",
                    ProductCategoryId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 10,
                    Name = "Gruszka konferencja",
                    MeasureType = MeasureType.Kilogram,
                    Price = 4.62M,
                    Availability = 10,
                    IsAvailable = true,
                    ImagePath = "gruszka_konferencja.jpg",
                    ProductCategoryId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 11,
                    Name = "Cytryna",
                    MeasureType = MeasureType.Kilogram,
                    Price = 9.70M,
                    Availability = 4,
                    IsAvailable = true,
                    ImagePath = "cytryna.jpg",
                    ProductCategoryId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."

                },
                new Product()
                {
                    Id = 12,
                    Name = "Ananas",
                    MeasureType = MeasureType.Piece,
                    Price = 8.65M,
                    Availability = 4,
                    IsAvailable = true,
                    ImagePath = "ananas.jpg",
                    ProductCategoryId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 13,
                    Name = "Banany premium",
                    MeasureType = MeasureType.Kilogram,
                    Price = 3.62M,
                    Availability = 40,
                    IsAvailable = true,
                    ImagePath = "bananypremium.jpg",
                    ProductCategoryId = 2,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                ////////////////////////////////////////////////////////////////////////////////
                ///PIECZYWO/////////////////////////////////////////////////////////////////////
                new Product()
                {
                    Id = 14,
                    Name = "Chleb biały",
                    MeasureType = MeasureType.Piece,
                    Price = 2.40M,
                    Availability = 5,
                    IsAvailable = true,
                    ImagePath = "chleb_biały.jpg",
                    ProductCategoryId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 15,
                    Name = "Bułka grahamka",
                    MeasureType = MeasureType.Piece,
                    Price = 0.90M,
                    Availability = 31,
                    IsAvailable = true,
                    ImagePath = "bułka_grahamka.jpg",
                    ProductCategoryId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 16,
                    Name = "Bułka kajzerka",
                    MeasureType = MeasureType.Piece,
                    Price = 0.40M,
                    Availability = 46,
                    IsAvailable = true,
                    ImagePath = "bułka_kajzerka.jpg",
                    ProductCategoryId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 17,
                    Name = "Bułka paryska",
                    MeasureType = MeasureType.Piece,
                    Price = 0.40M,
                    Availability = 46,
                    IsAvailable = true,
                    ImagePath = "bułka_paryska.jpg",
                    ProductCategoryId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 18,
                    Name = "Bagietka czosnkowa",
                    MeasureType = MeasureType.Piece,
                    Price = 0.40M,
                    Availability = 46,
                    IsAvailable = true,
                    ImagePath = "bagietka_czosnkowa.jpg",
                    ProductCategoryId = 3,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                ///////////////////////////////////////////////////////////////////////////////
                ///NABIAL
                new Product()
                {
                    Id = 19,
                    Name = "Mleko",
                    MeasureType = MeasureType.Piece,
                    Price = 3.40M,
                    Availability = 32,
                    IsAvailable = true,
                    ImagePath = "mleko.jpg",
                    ProductCategoryId = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 20,
                    Name = "Ser gouda",
                    MeasureType = MeasureType.Kilogram,
                    Price = 15.40M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "ser_gouda.jpg",
                    ProductCategoryId = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 21,
                    Name = "Twaróg chudy",
                    MeasureType = MeasureType.Piece,
                    Price = 4.40M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "twaróg_chudy.jpg",
                    ProductCategoryId = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 22,
                    Name = "Jajko",
                    MeasureType = MeasureType.Piece,
                    Price = 0.80M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "jajko.jpg",
                    ProductCategoryId = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 23,
                    Name = "Camembert",
                    MeasureType = MeasureType.Piece,
                    Price = 15.40M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "camembert.jpg",
                    ProductCategoryId = 4,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                //////////////////////////////////////////////////////////////////////////////////////
                ///MIESO
                new Product()
                {
                    Id = 24,
                    Name = "Pierś z kurczaka",
                    MeasureType = MeasureType.Kilogram,
                    Price = 16.30M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "kurczak_pierś.jpg",
                    ProductCategoryId = 5,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 25,
                    Name = "Kiełbasa krakowska",
                    MeasureType = MeasureType.Kilogram,
                    Price = 10.30M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "krakowska.jpg",
                    ProductCategoryId = 5,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 26,
                    Name = "Schab",
                    MeasureType = MeasureType.Kilogram,
                    Price = 25.33M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "schab.jpg",
                    ProductCategoryId = 5,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 27,
                    Name = "Kurczak cały",
                    MeasureType = MeasureType.Piece,
                    Price = 25.60M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "kurczak_caly.jpg",
                    ProductCategoryId = 5,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                new Product()
                {
                    Id = 28,
                    Name = "Wołowina",
                    MeasureType = MeasureType.Kilogram,
                    Price = 40.30M,
                    Availability = 3,
                    IsAvailable = true,
                    ImagePath = "wolowina.jpg",
                    ProductCategoryId = 5,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                },
                //////////////////////////////////////////////////////////////////////////
                ///Soki
                new Product()
                {
                    Id = 29,
                    Name = "Sok pomarańczowy",
                    MeasureType = MeasureType.Liter,
                    Price = 6.30M,
                    Availability = 20,
                    IsAvailable = true,
                    ImagePath = "sok_pomaranzowy.jpg",
                    ProductCategoryId = 6,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id."
                }
                ); ;
                

            modelBuilder.Entity<Rating>().HasData(
                new Rating()
                {
                    Id = 1,
                    Rate = 4,
                    RatingDate = DateTime.Today,
                    Message = "Bardzo dobre!",
                    ProductId = 1
                },
                new Rating()
                {
                    Id = 2,
                    Rate = 1,
                    RatingDate = DateTime.Today,
                    Message = "Baton przeterminowany.",
                    ProductId = 1
                },
                new Rating()
                {
                    Id = 3,
                    Rate = 5,
                    RatingDate = DateTime.Today,
                    Message = "Super szybka dostawa!",
                    ProductId = 1
                },
                new Rating()
                {
                    Id = 4,
                    Rate = 5,
                    RatingDate = DateTime.Today,
                    Message = "Pyszne",
                    ProductId = 2
                }
                ); ;

                modelBuilder.Entity<Cart>().HasData(
                new Cart()
                {
                    Id = 1,
                    OrderId = 1
                },
                new Cart()
                {
                    Id = 2,
                    OrderId = 2
                },
                new Cart()
                {
                    Id = 3,
                    OrderId = 3
                }
                ); ;

                modelBuilder.Entity<Delivery>().HasData(
                new Delivery()
                {
                    Id = 1,
                    DeliveryTypeName = "Pocztex48",
                    Price = 8.50
         
                },
                new Delivery()
                {
                    Id = 2,
                    DeliveryTypeName = "Kurier DPD",
                    Price = 10.90
                },
                new Delivery()
                {
                    Id = 2,
                    DeliveryTypeName = "Kurier DHL",
                    Price = 12.90

                }
                ); ;

                modelBuilder.Entity<ProductInCart>().HasData(
                new ProductInCart()
                {
                    Id = 1,
                    ProductAmount = 1,
                    ProductId = 1,
                    CartId = 1
                },
                new ProductInCart()
                {
                    Id = 2,
                    ProductAmount = 2,
                    ProductId = 29,
                    CartId = 1
                },
                new ProductInCart()
                {
                    Id = 3,
                    ProductAmount = 3,
                    ProductId = 17,
                    CartId = 2
                },
                new ProductInCart()
                {
                    Id = 4,
                    ProductAmount = 1,
                    ProductId = 9,
                    CartId = 2
                },
                new ProductInCart()
                {
                    Id = 5,
                    ProductAmount = 1,
                    ProductId = 21,
                    CartId = 3
                },
                new ProductInCart()
                {
                    Id = 6,
                    ProductAmount = 3,
                    ProductId = 19,
                    CartId = 3
                },
                new ProductInCart()
                {
                    Id = 7,
                    ProductAmount = 2,
                    ProductId = 25,
                    CartId = 3
                }
                ); ;


            modelBuilder.Entity<OrdersHistory>().HasData(
                new OrdersHistory()
                {
                    Id = 1 
                }
                ); ;

            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    DeliveryAddress = "Krynicka 14 50-555 Wrocław",
                    OrderDate = DateTime.Today,
                    TypeOfPayment = TypeOfPayment.OnDelivery,
                    IsOrderPaid = true,
                    OrderPaymentDate = DateTime.Today,
                    DeliveryId = 1,
                    CartId = 1,
                    OrdersHistoryId = 1
                },
                new Order()
                {
                    Id = 2,
                    DeliveryAddress = "Krynicka 14 50-555 Wrocław",
                    OrderDate = DateTime.Today,
                    TypeOfPayment = TypeOfPayment.Electronic,
                    IsOrderPaid = false,
                    DeliveryId = 2,
                    CartId = 2,
                    OrdersHistoryId = 1
                },
                new Order()
                {
                    Id = 3,
                    DeliveryAddress = "Krynicka 14 50-555 Wrocław",
                    OrderDate = DateTime.Today,
                    TypeOfPayment = TypeOfPayment.Electronic,
                    IsOrderPaid = false,
                    DeliveryId = 3,
                    CartId = 3,
                    OrdersHistoryId = 1
                }
                ); ;
        }
    }
}
