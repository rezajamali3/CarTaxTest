





using CarTax.Car.Domain;
using CarTax.Car.Domain.Repository;
using CarTax.Car.Infrastruchar;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Infrastruchar.Repositories
{
    public class CarRepository : RepositoryBase<Cars>
    {

        public CarRepository(CarDBContext dbContext) : base(dbContext)
        {

        }

    }
}
