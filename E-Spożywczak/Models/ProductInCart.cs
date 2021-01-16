using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class ProductInCart
    {
        public int ProductInChartProductId;
        public Product ProductInChartProduct;

        public double ProductInChartAmount;

        public int ProductInCartCartId;
        public Cart ProductInCartCart;

    }
}
