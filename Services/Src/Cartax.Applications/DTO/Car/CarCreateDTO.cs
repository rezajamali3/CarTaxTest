using Cartax.Applications.Common.Base;
using Cartax.Applications.DTO.Car.IContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car
{
    public class CarCreateDTO : BaseDTO, ICarDTO
    {
    
     
        public int IdCarType { get; set; }
        public string CarName { get; set; }
    }
}
