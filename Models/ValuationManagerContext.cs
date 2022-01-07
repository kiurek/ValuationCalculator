using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValuationCalculator.Models
{
    public class ValuationManagerContext : DbContext
    {
        public ValuationManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ValuationModel> Valuations { get; set; }
    }
}
