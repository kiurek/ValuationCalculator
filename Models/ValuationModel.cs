using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValuationCalculator.Models
{
    public class ValuationModel
    {
        [DisplayName("Numer jednostki")]
        public int ValuationId { get; set; }

        [DisplayName("Wzór")]
        public string Model { get; set; }

        [DisplayName("Kolor")]
        public int Color { get; set; }

        [DisplayName("Grubość")]
        public int Thickness { get; set; }

        [DisplayName("Wysokość")]
        [Required(ErrorMessage = "Proszę podać wysokość")]
        public decimal Height { get; set; }

        [DisplayName("Szerokość")]
        [Required(ErrorMessage = "Proszę podać szerokość")]
        public decimal Width { get; set; }

        
        [DisplayName("Ilość")]
        public int Amount { get; set; }


        [DisplayName("Cena")]
        public decimal Price { get; set; }


    }
}
