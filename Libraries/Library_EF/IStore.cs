using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public interface IStore : IDatabase
    {
        IQueryable<TEntity> GetEntitySet<TEntity>() where TEntity : Entity;
        void Add<TEntity>(TEntity order) where TEntity : Entity;
    }
}
