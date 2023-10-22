

namespace Library_EF
{
    public interface IUnitOfWork
    {
        Task<int> Commit();
    }
}