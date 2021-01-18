using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_Spożywczak.Models
{
    public enum MeasureType
    {
        [Display(Name = "Szt.")]
        Piece,
        [Display(Name = "Kg")]
        Kilogram,
        [Display(Name = "L")]
        Liter
    }

    public class Product
    {
        // Primary
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public MeasureType MeasureType { get; set; }
        public double Availability { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }

        // Foreign
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
