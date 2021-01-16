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
        public int Id;
        public double Amount;

        // Foreign
        public int ProductId;
        public Product Product;

        public int CartId;
        public Cart Cart;
    }
}
