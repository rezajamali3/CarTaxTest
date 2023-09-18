using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxLimitDays
{
    public class TaxLimitDayDTO : BaseDTO
    {
        public TimeSpan? Time { get; set; }
        public bool? IsActive { get; set; }
    }
}
