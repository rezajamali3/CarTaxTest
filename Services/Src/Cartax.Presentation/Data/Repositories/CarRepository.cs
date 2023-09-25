using Cartax.Applications.Common.Base;

using Cartax.Domain.Entites.Cars;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
