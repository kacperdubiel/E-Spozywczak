using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual IList<ProductInCart> ProductsInCart { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Cena całkowita")]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Zamówienie")]
        public Order Order { get; set; }
    }
}
