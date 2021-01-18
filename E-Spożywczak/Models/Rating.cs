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
        public int Id { get; set; }
        public int Rate { get; set; }
        public DateTime RatingDate { get; set; }
        public string Message { get; set; }

        // Foreign
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
