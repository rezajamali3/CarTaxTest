using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public class AppDbContext : DbContext, IStore
    {
        public DbSet<Order> Orders { get; set; }
        public async Task<ITransaction> BeginTransaction()
        {
            var transaction = await Database.BeginTransactionAsync();
            return new EfTransaction(transaction);
        }


        //public IQueryable<TEntity> GetEntitySet<TEntity>() where TEntity : class => Set<TEntity>();

        //public void Add<TEntity>(TEntity entity) where TEntity : class
        //{
        //   Set<Entity>().Add(entity);
        //}

        public async Task<ITransaction> BeginTransactionAsync()
        {
            var transaction = await Database.BeginTransactionAsync();
            return new EfTransaction(transaction);
        }

        public IQueryable<TEntity> GetEntitySet<TEntity>() where TEntity : Entity
        {
            throw new NotImplementedException();
        }

        void IStore.Add<TEntity>(TEntity order)
        {
            throw new NotImplementedException();
        }
    }
}
