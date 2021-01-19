using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductInCart
    {
        // Primary
        [Key]
        [Display(Name = "ID produktu w koszyku")]
        public int Id { get; set; }

        [Display(Name = "Ilość produktu")]
        public double ProductAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Cena całkowita")]
        public decimal TotalPrice { get; set; }

        // Foreign
        [Display(Name = "ID produktu")]
        public int ProductId { get; set; }

        [Display(Name = "Produkt")]
        public Product Product { get; set; }

        [Display(Name = "ID koszyka")]
        public int CartId { get; set; }

        [Display(Name = "Koszyk")]
        public Cart Cart { get; set; }
    }
}
