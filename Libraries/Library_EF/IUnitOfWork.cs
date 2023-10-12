

namespace CarTax.Car.Application
{
    public interface IUnitOfWork
    {
        Task<int> Commit();
    }
}