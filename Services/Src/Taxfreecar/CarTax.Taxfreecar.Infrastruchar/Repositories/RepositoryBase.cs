
using Microsoft.EntityFrameworkCore;

using CarTax.Taxfreecar.Domain.Repositorys;
using CarTax.Taxfreecar.Domain.ValueObjects;
using CarTax.AggregateRoot;

namespace CarTax.Taxfreecar.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ITaxfreecarRepository where T :class
    {

        private  DbSet<T> _dbSet { get; }

        protected readonly TaxfreecarDBContext _dbContext;

        public RepositoryBase(TaxfreecarDBContext dbContext)
        {
                 _dbSet = dbContext.Set<T>();
                 _dbContext = dbContext;
        }

        public async Task AddAsync(TaxFreeCar entity)
            => await _dbContext.Taxfreecar.AddAsync(entity);

        public async Task<bool> Exists(TaxfreecarId carTypeId)
         => await _dbContext
           .Taxfreecar
           .FindAsync(carTypeId.Value)
            is not null;

        public async Task<TaxFreeCar> Load(TaxfreecarId carTypeId)
         => await _dbContext.Taxfreecar.FindAsync(carTypeId);

        public async Task DeleteAsync(TaxFreeCar entity)
       =>  _dbContext.Taxfreecar.Remove(entity);

        public void Dispose() => _dbContext.Dispose();

    }
}

