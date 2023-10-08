

namespace Library_Domain.Interface
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();


    }
}