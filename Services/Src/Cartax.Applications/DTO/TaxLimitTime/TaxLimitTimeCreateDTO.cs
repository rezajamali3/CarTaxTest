using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxLimitTime
{
    public class TaxLimitTimeCreateDTO :BaseDTO
    {
       
        public TimeSpan? Time { get; set; }
    }
}
