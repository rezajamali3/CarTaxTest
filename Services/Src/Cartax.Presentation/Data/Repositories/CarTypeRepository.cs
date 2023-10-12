<<<<<<< HEAD
﻿
using Cartax.Applications.Common.Base;

=======
﻿using Cartax.Applications.Base;
using Cartax.Applications.Interfaces;
using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
using Cartax.Presentation;


namespace Cartax.Applications.Persistence.Repositories
{
    public class CarTaypsRepository : RepositoryBase<CarType>, ICarTypesRepository
    {
        public CarTaypsRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
