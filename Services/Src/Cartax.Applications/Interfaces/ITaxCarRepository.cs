using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Tax.TaxCars;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Interfaces
{
    public interface ITaxCarRepository : IAsyncRepository<TaxCar>
    {

        public Task<TaxCar> GetTaxCarEndToday(int? idCar, int? idArea);
    }
}
