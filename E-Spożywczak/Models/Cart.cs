using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Cart
    {
        // Primary
        [Key]
        [Display(Name = "ID koszyka")]
        public int Id { get; set; }

        // Foreign
        [Display(Name = "Produkty w koszyku")]
        ICollection<ProductInCart> ProductsInCart { get; set; }

        [Display(Name = "Zamówienie")]
        public Order Order { get; set; }
    }
}
