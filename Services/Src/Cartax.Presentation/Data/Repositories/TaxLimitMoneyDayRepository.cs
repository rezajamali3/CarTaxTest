using Cartax.Applications.Common.Base;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxLimitMoneyDays;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class TaxLimitMoneyDayRepository : RepositoryBase<TaxLimitMoneyDay>, ITaxLimitMoneyDayRepository
    {
        public TaxLimitMoneyDayRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
