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
        public int Id { get; set; }

        // Foreign
        ICollection<ProductInCart> ProductsInCart { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
