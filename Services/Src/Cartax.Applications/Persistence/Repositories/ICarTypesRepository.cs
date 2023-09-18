using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ICarTypesRepository : IAsyncRepository<CarType>
    {

    }
}
