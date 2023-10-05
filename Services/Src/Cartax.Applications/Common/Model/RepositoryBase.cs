


using System.Linq.Expressions;
using Cartax.Applications.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Cartax.Domain.Common.Model;


namespace Cartax.Applications.Common.Base
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : Entity
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext dbContext;
        public RepositoryBase(DbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            this.dbContext = dbContext;
        }



        public async Task<int> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

            int result = await dbContext.SaveChangesAsync();
            if (result != 0)
                return (int)entity.Id;
            return (int)entity.Id;

        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            int result = await dbContext.SaveChangesAsync();
            if (result != 0)
                return true;
            return false;
        }

        public Task<T> GetidAsync(int id)
        {
            return _dbSet.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> expression)
        {
            var result = await _dbSet
                .FirstOrDefaultAsync(expression)
                .ToAsyncEnumerable().FirstOrDefaultAsync();

            return result;
        }

        public Task<List<T>> ListAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToListAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            int result = await dbContext.SaveChangesAsync();
            if (result != 0)
                return true;
            return false;
        }


    }
}
