
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Cartax.Domain.Entites.Tax.TaxTimes;

using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Presentation;
using Cartax.Applications.Common.Base;

namespace Cartax.Applications.Persistence.Repositories
{
    public class TaxWeekDayRepository : RepositoryBase<TaxWeekDay>, ITaxWeekDayRepository
    {
        public TaxWeekDayRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
