using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Cart
    {
        public int CartId;
        ICollection<ProductInCart> CartProductsInCartList;
        public Order CartOrder; 
    }
}
