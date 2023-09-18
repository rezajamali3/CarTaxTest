using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Applications.Common.Base;

namespace Cartax.WebAPI.DTO.TaxTimes
{
    public class TaxTimeDTO : BaseDTO
    {
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public decimal Tax { get; set; }
        public int Idarea { get; set; }
    }
}
