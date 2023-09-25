using Cartax.Applications.Common.Base;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
