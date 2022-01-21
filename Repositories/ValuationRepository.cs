using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Models;

namespace ValuationCalculator.Repositories
{
    public class ValuationRepository : IValuationRepository
    {
        private readonly ValuationManagerContext _context;
        
        public ValuationRepository(ValuationManagerContext context)
        {
            _context = context;
        }

        public IQueryable<ValuationModel> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void Add(ValuationModel valuation)
        {
            throw new NotImplementedException();
        }

        public void Update(int valuationId, ValuationModel valuation)
        {
            throw new NotImplementedException();
        }

        public void Delete(int valuationId)
        {
            throw new NotImplementedException();
        }

        public ValuationModel Get(int valuationId)
        {
            throw new NotImplementedException();
        }
    }
}
