
using Microsoft.EntityFrameworkCore;


using CarTax.City.Domain;
using CarTax.City.Domain.Repositorys;
using CarTax.City.Domain.ValueObjects;



namespace CarTax.City.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ICityRepository where T :class
    {

        private  DbSet<T> _dbSet { get; }

        protected readonly CityDBContext _dbContext;

        public RepositoryBase(CityDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
                 _dbContext = dbContext;
        }

        public async Task AddAsync(Citys entity)
            => await _dbContext.CarTypes.AddAsync(entity);

        public async Task<bool> Exists(CityId carTypeId)
         => await _dbContext
           .CarTypes
           .FindAsync(carTypeId.Value)
            is not null;

        public async Task<Citys> Load(CityId carTypeId)
         => await _dbContext.CarTypes.FindAsync(carTypeId);

        public async Task DeleteAsync(Citys entity)
       =>  _dbContext.CarTypes.Remove(entity);

        public void Dispose() => _dbContext.Dispose();

    }
}

