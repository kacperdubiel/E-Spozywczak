using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId;
        public string ProductCategoryName;
        public ICollection<Product> ProductCategoryProducts;
    }
}
