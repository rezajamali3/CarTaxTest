using Cartax.Applications.Base;
using Cartax.Applications.Interfaces;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class TaxPublicholidayRepository : RepositoryBase<TaxPublicholiday>, ITaxPublicholidayRepository
    {
        public TaxPublicholidayRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
