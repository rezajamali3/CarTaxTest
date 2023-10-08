using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.CarType
{
    public class CarTypesCreateDTO : BaseDTO
    {
        public string CarName { get; set; }
        public int IdCity { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxActive { get; set; }
    }
}
