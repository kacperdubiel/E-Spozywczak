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
        public int Id;
        public string Name;
        public double Price;

        // Foreign
        public ICollection<Order> Orders;
    }
}
