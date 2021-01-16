using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId;
        public string ProductCategoryName;
        public ICollection<Product> ProductCategoryProducts;
    }
}
