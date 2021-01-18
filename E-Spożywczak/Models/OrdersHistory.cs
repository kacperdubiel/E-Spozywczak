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
        public int Id { get; set; }

        // Foreign
        public ICollection<Order> Orders { get; set; }
    }
}
