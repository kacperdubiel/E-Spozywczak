using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_Spożywczak.Models
{
    public enum MeasureType
    {
        [Display(Name = "Szt.")]
        Piece,
        [Display(Name = "Kg.")]
        Kilogram,
        [Display(Name = "L.")]
        Liter
    }

    public class Product
    {
        // Primary
        [Display(Name = "ID produktu")]
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Cena za jednostkę")]
        public decimal Price { get; set; }

        [Display(Name = "Jednostka")]
        public MeasureType MeasureType { get; set; }

        [Display(Name = "Dostępność")]
        public double Availability { get; set; }

        [Display(Name = "Stan dostępności")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Zdjęcie")]
        public string ImagePath { get; set; }

        // Foreign
        [Display(Name = "ID kategorii")]
        public int ProductCategoryId { get; set; }

        [Display(Name = "Kategoria")]
        public ProductCategory ProductCategory { get; set; }

        [Display(Name = "Ocena")]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
