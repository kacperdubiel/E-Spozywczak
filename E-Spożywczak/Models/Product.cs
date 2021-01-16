using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public enum MeasureType
    {
        Piece,
        Kilogram,
        Liter
    }

    public class Product
    {
        // Primary
        [Key]
        public int Id;
        public string Name;
        public MeasureType MeasureType;
        public double Availability;
        public bool IsAvailable;
        public string ImagePath;

        // Foreign
        public int ProductCategoryId;
        public ProductCategory ProductCategory;

        public ICollection<Rating> Ratings;
    }
}
