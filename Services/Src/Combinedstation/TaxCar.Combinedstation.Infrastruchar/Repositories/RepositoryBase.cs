
using Microsoft.EntityFrameworkCore;
using TaxCar.Combinedstation.Core;
using TaxCar.Combinedstation.Core.Repository;
using TaxCar.Combinedstation.Infrastruchar;

namespace CarTax.Combinedstation.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ICombinedStationRepository where T :class
    {

        private  DbSet<T> _dbSet { get; }

        protected readonly CombinedstationDBContext _dbContext;

        public RepositoryBase(CombinedstationDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _dbContext = dbContext;
        }

        public async Task<CombinedStations> AddAsync(CombinedStations entity)
        {
           var result= await _dbContext.CombinedStations.AddAsync(entity);
            return result.Entity;
        }

        public async Task<CombinedStations> DeleteAsync(CombinedStations entity)
        {
            var result = _dbContext.CombinedStations.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> Exists(Guid combinedStationsId)
        => await _dbContext
           .CombinedStations
           .FindAsync(combinedStationsId)
            is not null;

        public async Task<CombinedStations> Find(Guid combinedStationsId)
        => await _dbContext.CombinedStations.FindAsync(combinedStationsId);

      
        public void Dispose()
        => _dbContext.Dispose();

        public async Task<bool> Commit()
        => await _dbContext.SaveChangesAsync() !=0 ;
       
    }
}

