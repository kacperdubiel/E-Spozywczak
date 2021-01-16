using System;
using System.Collections.Generic;
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
        public int ProductId;
        public string ProductName;
        public MeasureType ProductMeasureType;
        public double ProductAvailability;
        public bool IsProductAvailable;
        public ProductCategory ProductCategory;
        public int ProductCategoryId;
        public string ProductImagePath;
    }
}
