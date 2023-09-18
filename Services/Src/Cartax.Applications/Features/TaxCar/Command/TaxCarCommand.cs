
using Cartax.Applications.Common.Primitives;
using Cartax.Applications.DTO.Car;
using Cartax.Domain.Entites.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Services.TaxCarServices.Command
{
    public record TaxCarCommand(int idCar,int idArea,DateTime CreateTime) : ICommend;
}
