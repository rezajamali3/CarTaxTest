using Cartax.Applications.Base;
using Cartax.Applications.Interfaces;
using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class CarTaypsRepository : RepositoryBase<CarType>, ICarTypesRepository
    {
        public CarTaypsRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
