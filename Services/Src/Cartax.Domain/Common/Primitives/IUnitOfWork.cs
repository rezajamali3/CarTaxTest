

using System.Threading.Tasks;

namespace Cartax.Domain.Common.Primitives
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();


    }
}