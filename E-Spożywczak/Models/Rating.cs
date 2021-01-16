using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Rating
    {
        [Key]
        public int RatingId;
        public int RatingValue;
        public DateTime RatingDate;
        public string RatingMessage;

        public ICollection<Product> RatingProductsList;
    }
}
