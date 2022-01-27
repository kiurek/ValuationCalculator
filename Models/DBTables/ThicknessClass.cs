using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValuationCalculator.Models
{
    public class ThicknessClass
    {
        [Key]
        public int ThicknessID { get; set; }
        public int Thickness { get; set; }
        public string Information { get; set; }
        public decimal Price { get; set; }
    }
}
