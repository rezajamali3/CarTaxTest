using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car
{
    public class CarDTO : BaseDTO
    {
      
        public int IdCarType { get; set; }
        public string CarName { get; set; }
    }
}
