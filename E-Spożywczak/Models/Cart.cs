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
        public int Id;

        // Foreign
        ICollection<ProductInCart> ProductInCarts;

        public int OrderId;
        public Order Order; 
    }
}
