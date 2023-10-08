using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Interfaces
{
    public interface ITaxLimitDayRepository : IAsyncRepository<TaxLimitDay>
    {
    }
}
