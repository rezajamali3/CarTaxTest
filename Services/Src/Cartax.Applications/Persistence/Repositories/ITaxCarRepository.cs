using Cartax.Domain.Entites.Tax.TaxCars;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface ITaxCarRepository : IAsyncRepository<TaxCar>
    {

        public Task<TaxCar> GetTaxCarEndToday(int? idCar, int? idArea);
    }
}
