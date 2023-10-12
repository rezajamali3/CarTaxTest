
using CarTax.CarType;
using CarTax.Car.Infrastruchar.Repositories;
using CarTax.CarType.Domain.Repositorys;
using Microsoft.EntityFrameworkCore;
using CarTax.CarType.Domain;
using CarTax.Car.Application;
using NPOI.SS.Formula.Functions;
using CarTax.CarType.Domain.ValueObjects;

namespace CarTax.CarType.Infrastruchar.Repositories
{
    public class CarTaypsRepository : RepositoryBase<CarTypes>, ICarTypeRepository
    {

        public CarTaypsRepository(CarTypeDBContext dbContext) : base(dbContext)
        {

        }

     

    }
}
