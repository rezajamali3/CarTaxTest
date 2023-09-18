using Cartax.Domain.Entites.Tax.TaxTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ITaxTimeRepository : IAsyncRepository<TaxTime>
    {
    }
}
