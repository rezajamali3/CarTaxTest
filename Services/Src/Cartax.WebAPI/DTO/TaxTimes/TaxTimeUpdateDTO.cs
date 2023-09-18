using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxTimes
{
    public class TaxTimeUpdateDTO : BaseDTO
    {
        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public decimal Tax { get; set; }
    }



}
