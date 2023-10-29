
using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

using CarTax.Car.Infrastruchar;
using CarTax.CarType.Domain;
using CarTax.CarType.Domain.Repositorys;
using CarTax.CarType.Domain.ValueObjects;

using TaxCar.CarType.Infrastruchar;

namespace CarTax.Car.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ICarTypeRepository where T :class
    {

        private  DbSet<T> _dbSet { get; }

        protected readonly CarTypeDBContext _dbContext;

        public RepositoryBase(CarTypeDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
                 _dbContext = dbContext;
        }

        public async Task AddAsync(CarTypes entity)
            => await _dbContext.CarTypes.AddAsync(entity);

        public async Task<bool> Exists(CarTypeId carTypeId)
         => await _dbContext
           .CarTypes
           .FindAsync(carTypeId.Value)
            is not null;

        public async Task<CarTypes> Load(CarTypeId carTypeId)
         => await _dbContext.CarTypes.FindAsync(carTypeId);

        public async Task DeleteAsync(CarTypes entity)
       =>  _dbContext.CarTypes.Remove(entity);

        public void Dispose() => _dbContext.Dispose();

    }
}

