using Cartax.Applications.Common.Primitives;
using Cartax.Applications.DTO.Car;

namespace Cartax.Applications.Features.Cars.Command
{
   
        public record CarCreateCommand(CarCreateDTO car) : ICommend;
  
}
