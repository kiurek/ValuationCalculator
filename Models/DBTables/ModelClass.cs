using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValuationCalculator.Models
{
    public class ModelClass
    {
        [Key]
        public int WindowsillID { get; set; }
        public string ModelName { get; set; }
        public string Desciption { get; set; }
        public decimal Price { get; set; }
    }
}
