using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_Spożywczak.Models
{
    public class ProductCategory
    {
        // Primary
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign
        public ICollection<Product> Products { get; set; }
    }
}
