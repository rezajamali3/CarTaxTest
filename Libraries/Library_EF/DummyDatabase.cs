using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public class DummyDatabase : IStore
    {
        private readonly List<Order> _orders = new List<Order>();

        public IQueryable<TEntity> GetEntitySet<TEntity>() where TEntity : Entity
            => _orders.AsQueryable() as IQueryable<TEntity>;

        public Task<ITransaction> BeginTransactionAsync()
        {
            return Task.FromResult(new EfTransaction(null) as ITransaction);
        }

        public void Add<TEntity>(TEntity order) where TEntity : Entity
        {
            _orders.Add(order as Order);
        }
    }


    public class Order : Entity
    {
        
    }
}
