using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Areas
{
    public class AreaCreateDTO : BaseDTO
    {
        public string? AreaName { get; set; }
        public string? AreaCode { get; set; }
        public int? IdCity { get; set; }
    }
}
