

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using Polly;
using CarTax.Area.Domain.Repository;
using CarTax.Area.Infrastruchar;
using CarTax.Area.Domain;
using CarTax.Area.Domain.ValueObjects;

namespace CarTax.Area.Infrastruchar.Repositories
{

    public class RepositoryBase<T> : IAreaRepository where T : class
    {


        private readonly AreasDBContext _dbContext;
        private DbSet<T> _dbSet { get; }

        public RepositoryBase(AreasDBContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _dbContext = dbContext;
        }

        public async Task AddAsync(Areas entity)
        => await _dbContext.Areas.AddAsync(entity); 

        public async Task<bool> Exists(AreaId id)
        =>await _dbSet.FindAsync(id) != null;


        public async Task DeleteAsync(Areas entity)
        => _dbContext.Areas.Remove(entity);


        public async Task<Areas> Load(AreaId entity)
        => await _dbContext.Areas.FindAsync(entity);
    

        public void Dispose() 
        => _dbContext.Dispose();


    }
}

