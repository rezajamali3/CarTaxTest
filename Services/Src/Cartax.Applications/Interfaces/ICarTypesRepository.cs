using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Interfaces
{
    public interface ICarTypesRepository : IAsyncRepository<CarType>
    {

    }
}
