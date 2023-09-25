using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Cars;


namespace Cartax.Applications.Interfaces
{
    public interface ICarRepository : IAsyncRepository<Car>
    {
    }
}
