using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class OrdersHistory
    {
        // Primary
        [Key]
        [Display(Name = "ID historii")]
        public int Id { get; set; }

        // Foreign
        [Display(Name = "Zamówienia w historii")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
