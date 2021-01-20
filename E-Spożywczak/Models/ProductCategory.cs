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
        [Display(Name = "ID kategorii")]
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        // Foreign
        [Display(Name = "Produkty w kategorii")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
