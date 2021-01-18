using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Cena")]
        public double Price { get; set; }

        // Foreign
        [Display(Name = "Zamówienie")]
        public ICollection<Order> Orders { get; set; }
    }
}
