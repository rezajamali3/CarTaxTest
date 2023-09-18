using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxLimitDays
{
    public class TaxLimitDayUpdateDTO : BaseDTO
    {
        public int? Id { get; set; }
        public TimeSpan? Time { get; set; }
        public bool? IsActive { get; set; }
    }
}
