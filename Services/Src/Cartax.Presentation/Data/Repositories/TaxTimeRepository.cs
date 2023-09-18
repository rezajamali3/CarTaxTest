using Cartax.Applications.Common.Base;
using Cartax.Domain.Entites.Areas;

using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class TaxTimeRepository : RepositoryBase<TaxTime>, ITaxTimeRepository
    {
        public TaxTimeRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
