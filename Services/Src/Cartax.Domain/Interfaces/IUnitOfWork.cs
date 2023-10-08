using Cartax.Domain.Base;
using Cartax.Domain.Primitives;

using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        //IAsyncRepository<T> AsyncRepository<T>() where T : Entity;
    }
}