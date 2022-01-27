using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Areas.Identity.Data;

namespace ValuationCalculator.Models
{
    public class ValuationManagerContext : DbContext
    {
        public ValuationManagerContext(DbContextOptions<ValuationManagerContext> options) : base(options)
        {
        }

        public DbSet<ModelClass> WindowsillsModels { get; set; }

        public DbSet<ColorsClass> Colors { get; set; }

        public DbSet<ThicknessClass> Thicknesses { get; set; }
        
        public DbSet<ValuationCalculatorUser> Customer { get; set; }
    }
}
