using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValuationCalculator.Models
{
    public class ColorsClass
    {
        [Key]
        public int FoilID { get; set; }
        public string Color { get; set; }
        public string FoilType { get; set; }
        public decimal AdditionalPrice { get; set; }
    }
}
