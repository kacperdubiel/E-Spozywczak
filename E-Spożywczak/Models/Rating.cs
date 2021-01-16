using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Rating
    {
        // Primary
        [Key]
        public int Id;
        public int Rate;
        public DateTime RatingDate;
        public string Message;

        // Foreign
        public int ProductId;
        public Product Product;
    }
}
