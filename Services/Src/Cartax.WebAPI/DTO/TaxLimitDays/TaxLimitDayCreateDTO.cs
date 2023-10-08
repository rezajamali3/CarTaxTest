using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxLimitDays
{
    public class TaxLimitDayCreateDTO : BaseDTO
    {
        public TimeSpan? Time { get; set; }
    }
}
