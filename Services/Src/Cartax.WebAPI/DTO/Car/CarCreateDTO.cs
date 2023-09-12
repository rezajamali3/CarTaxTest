using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.Car
{
    public class CarCreateDTO : BaseDTO
    {

        public int IdCarType { get; set; }
        public string CarName { get; set; }
    }
}
