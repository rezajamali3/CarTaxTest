using Cartax.Domain.Entites.Citys;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ICityRepository : IAsyncRepository<City>
    {
    }
}
