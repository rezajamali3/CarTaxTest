using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Domain.Interfaces;

namespace Cartax.Applications.Interfaces
{
    public interface ITaxWeekDayRepository : IAsyncRepository<TaxWeekDay>
    {


    }
}
