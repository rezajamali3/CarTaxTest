using Cartax.Domain.Entites.Tax.TaxLimitMoneyDays;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ITaxLimitMoneyDayRepository : IAsyncRepository<TaxLimitMoneyDay>
    {
    }
}
