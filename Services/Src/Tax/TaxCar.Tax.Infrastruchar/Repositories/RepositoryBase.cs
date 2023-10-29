
using Microsoft.EntityFrameworkCore;


using CarTax.Tax.Domain;

using CarTax.Tax.Domain.ValueObjects;
using TaxCar.Tax.Infrastruchar;
using CarTax.Tax.Domain.Repositorys;

namespace CarTax.Tax.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ITaxCarAreaRepository where T :class
    {

        private  DbSet<T> _dbSet { get; }

        protected readonly TaxCarAreaDBContext _dbContext;

        public RepositoryBase(TaxCarAreaDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
                 _dbContext = dbContext;
        }

        public async Task AddAsync(TaxCarArea entity)
            => await _dbContext.TaxCarAreas.AddAsync(entity);

        public async Task<bool> Exists(TaxCarAreaId carTypeId)
         => await _dbContext
           .TaxCarAreas
           .FindAsync(carTypeId.Value)
            is not null;

        public async Task<TaxCarArea> Load(TaxCarAreaId carTypeId)
         => await _dbContext.TaxCarAreas.FindAsync(carTypeId);

        public async Task DeleteAsync(TaxCarArea entity)
       =>  _dbContext.TaxCarAreas.Remove(entity);

        public void Dispose() => _dbContext.Dispose();

    }
}

