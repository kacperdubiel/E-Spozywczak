using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Address
    {
        // Primary
        [Key]
        [Display(Name = "ID Adresu")]
        public int Id { get; set; }

        [Display(Name = "Ulica i numer mieszkania")]
        public string AddressLine { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string PostCode { get; set; }

        [Display(Name = "Miejscowość")]
        public string City { get; set; }

        [Display(Name = "Kraj")]
        public string Country { get; set; }
    }
}
