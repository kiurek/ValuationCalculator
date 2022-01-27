using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ValuationCalculator.Models
{
    public class ValuationModel
    {
        [DisplayName("Numer jednostki")]
        public int ValuationId { get; set; }

        [DisplayName("Wzór")]
        [Required(ErrorMessage = "Proszę wybrać model")]
        public string Model { get; set; }

        [DisplayName("Kolor")]
        [Required(ErrorMessage = "Proszę wybrać kolor")]
        public int Color { get; set; }


        [DisplayName("Grubość(podana w milimetrach)")]
        [Required(ErrorMessage = "Proszę wybrać grubość")]
        public int Thickness { get; set; }

        [DisplayName("Wysokość(w metrach)")]
        [Required(ErrorMessage = "Proszę podać wysokość")]
        [Range(0.10, 2.75, ErrorMessage = "Maksymalna szerokość wynosi 2.75 metra")]
        public double Height { get; set; }

        [DisplayName("Szerokość(w metrach)")]
        [Required(ErrorMessage = "Proszę podać szerokość")]
        [Range(0.10, 1.25, ErrorMessage = "Maksymalna szerokość wynosi 1.25 metra")]
        public double Width { get; set; }
        
        [DisplayName("Ilość")]
        [Required]
        public int Amount { get; set; }

        [DisplayName("Cena")]
        public double FinalPrice { get; set;}
    }
}
