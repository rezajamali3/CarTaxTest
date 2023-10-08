
using Cartax.Applications.Common.Primitives;


namespace Cartax.Applications.Services.TaxCarServices.Command
{
    public record TaxCarCommand(int idCar,int idArea,DateTime CreateTime) : ICommend;
}
