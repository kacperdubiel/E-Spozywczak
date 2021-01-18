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
        [Display(Name = "ID oceny")]
        public int Id { get; set; }

        [Display(Name = "Ocena")]
        public int Rate { get; set; }

        [Display(Name = "Data wystawienia oceny")]
        public DateTime RatingDate { get; set; }

        [Display(Name = "Komentarz")]
        public string Message { get; set; }

        // Foreign
        [Display(Name = "ID ocenianego produktu")]
        public int ProductId { get; set; }

        [Display(Name = "Oceniany produkt")]
        public Product Product { get; set; }
    }
}
