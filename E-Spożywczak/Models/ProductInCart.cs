using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductInCart
    {
        [Key]
        public int ProductInCartId;
        public int ProductInCartProductId;
        public Product ProductInCartProduct;

        public double ProductInCartAmount;

        public int ProductInCartCartId;
        public Cart ProductInCartCart;

    }
}
