using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductCategory
    {
        // Primary
        [Key]
        public int Id;
        public string Name;

        // Foreign
        public ICollection<Product> Products;
    }
}
