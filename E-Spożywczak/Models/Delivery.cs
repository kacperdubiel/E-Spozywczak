using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Delivery
    {
        // Primary
        [Key]
        [Display(Name = "ID dostawy")]
        public int Id { get; set; }

        [Display(Name = "Typ")]
        public string DeliveryTypeName { get; set; }

        [Display(Name = "Cena dostawy")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // Foreign
        [Display(Name = "Zamówienie")]
        public virtual IList<Order> Orders { get; set; }
    }
}
