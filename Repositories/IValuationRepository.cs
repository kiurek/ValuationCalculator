using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Models;

namespace ValuationCalculator.Repositories
{
    public interface IValuationRepository
    {
        ValuationModel Get(int valuationId);
        IQueryable<ValuationModel> GetAllActive();
        void Add(ValuationModel valuation);
        void Update(int valuationId, ValuationModel valuation);
        void Delete(int valuationId);
    }
}
