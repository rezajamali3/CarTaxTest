using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxLimitTime
{
    public class TaxLimitTimeUpdateDTO : BaseDTO
    {
       
        public TimeSpan? Time { get; set; }
        public bool? IsActive { get; set; }
    }
}
