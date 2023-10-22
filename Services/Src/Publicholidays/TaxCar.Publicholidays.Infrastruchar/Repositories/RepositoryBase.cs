

using Microsoft.EntityFrameworkCore;
using TaxCar.Publicholiday.Domain.ValueObjects;
using TaxCar.Publicholidays.Domain;
using TaxCar.Publicholidays.Domain.Repository;
using TaxCar.Publicholidays.Infrastruchar;

namespace TaxCar.Publicholidays.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : IPublicholidayRepository where T : class
    {

        private readonly PublicholidayDBContext _dbContext;
        private DbSet<T> _dbSet { get; }

        public RepositoryBase(PublicholidayDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _dbContext = dbContext;
        }

        public async Task AddAsync(Publicholiday entity)
        => await _dbContext.Publicholidays.AddAsync(entity); 

        public async Task<bool> Exists(PublicholidayId id)
        => await _dbSet.FindAsync(id) != null;


        public async Task DeleteAsync(Publicholiday entity)
        => _dbContext.Publicholidays.Remove(entity);
        

        public async Task<Publicholiday> Load(PublicholidayId entity)
        => await _dbContext.Publicholidays.FindAsync(entity);
       

        public void Dispose() 
        => _dbContext.Dispose();
    }
}

