using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductInCart
    {
        public int ProductInCartProductId;
        public Product ProductInCartProduct;

        public double ProductInCartAmount;

        public int ProductInCartCartId;
        public Cart ProductInCartCart;

    }
}
