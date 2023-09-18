using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.CarType
{
    public class CarTypesDTO : BaseDTO
    {
        public string CarName { get; set; }
        public int IdCity { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxActive { get; set; }
    }
}
