

using Library_Domain.Interface;
using TaxCar.Publicholiday.Domain.ValueObjects;
using TaxCar.Publicholidays.Domain;

namespace TaxCar.Publicholidays.Domain.Repository
{
    public interface IPublicholidayRepository : IAsyncRepository<Publicholiday>
    {

        Task<bool> Exists(PublicholidayId id);
        Task<Publicholiday> Load(PublicholidayId entity);
       

    }
}
