

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using CarTax.Car.Domain;
using CarTax.Car.Domain.Repository;
using CarTax.Car.Domain.ValueObjects;
using Polly;


namespace CarTax.Car.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ICarRepository where T : class
    {

        private readonly CarDBContext _dbContext;
        private DbSet<T> _dbSet { get; }

        public RepositoryBase(CarDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _dbContext = dbContext;
        }

        public async Task AddAsync(Cars entity)
        => await _dbContext.Cars.AddAsync(entity); 

        public async Task<bool> Exists(CarId id)
        =>await _dbSet.FindAsync(id) != null;



       

        public Task<List<T>> ListAsync(Expression<Func<T, bool>> expression)
        => _dbSet.Where(expression).ToListAsync();


       


     

        public async Task DeleteAsync(Cars entity)
        {
            _dbContext.Cars.Remove(entity);
         
        }

        public async Task<Cars> Load(CarId entity)
        {
            return await _dbContext.Cars.FindAsync(entity);
        }

        public void Dispose() => _dbContext.Dispose();
    }
}

