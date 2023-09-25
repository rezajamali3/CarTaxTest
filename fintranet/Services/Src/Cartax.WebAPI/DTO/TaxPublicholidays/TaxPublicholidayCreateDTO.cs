using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxPublicholidays
{
    public class TaxPublicholidayCreateDTO : BaseDTO
    {
        public DateTime Day { get; set; }
        public bool IsActive { get; set; }
    }
}
