using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car.IContract
{
    public interface ICarDTO
    {
         int IdCarType { get; set; }
         string CarName { get; set; }
    }
}
