using CarTax.Area.Domain;
using CarTax.Area.Domain.ValueObjects;

using Library_Domain.Interface;


namespace CarTax.Area.Domain.Repository
{
    public interface IAreaRepository : IAsyncRepository<Areas>
    {

        Task<bool> Exists(AreaId id);
        Task<Areas> Load(AreaId entity);
       

    }
}
