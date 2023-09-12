using Cartax.Applications.Base;
using Cartax.Applications.Interfaces;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    internal class TaxLimitTimeRepository : RepositoryBase<TaxLimitTime>, ITaxLimitTimeRepository
    {
        public TaxLimitTimeRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
