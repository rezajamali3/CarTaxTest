using Cartax.Domain.Entites.Tax.TaxLimitTimes;
using Cartax.Domain.Entites.Tax.TaxLongTerms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ITaxLimitTimeRepository : IAsyncRepository<TaxLimitTime>
    {
    }
}
