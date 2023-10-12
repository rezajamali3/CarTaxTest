


using System.Linq.Expressions;

using CarTax.Car.Infrastruchar;
using CarTax.CarType.Domain;
using CarTax.CarType.Domain.Repositorys;
using CarTax.CarType.Domain.ValueObjects;
using CarTax.CarType.Infrastruchar;
using Library_Domain.Model;
using Microsoft.EntityFrameworkCore;


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

        //public async Task<bool> Exists(CarTypeId id)
        //    => await _dbContext.CarTypes.FindAsync(id.Value) != null;

        public async Task<CarTypes> Load(CarTypeId id)
            => await _dbContext.CarTypes.FindAsync(id.Value);

        public void Dispose() => _dbContext.Dispose();

        public Task<CarTypes> Load(CarTypes entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CarTypes entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CarTypes entity)
        {
            throw new NotImplementedException();
        }

        public Task<CarTypes> GetAsync(Expression<Func<CarTypes, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarTypes>> ListAsync(Expression<Func<CarTypes, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Exists(CarTypeId carTypeId)
         => await _dbContext
           .CarTypes
           .FindAsync(carTypeId.Value)
            is not null;
        
    }
}

