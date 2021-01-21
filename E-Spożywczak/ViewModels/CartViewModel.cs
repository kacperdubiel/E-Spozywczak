using E_Spożywczak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }

        // Foreign
        public virtual ICollection<ProductInCart> ProductsInCart { get; set; }
    }
}
