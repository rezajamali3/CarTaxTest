using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxLongTerms
{
    public class TaxTaxLongTermDTO : BaseDTO
    {
        public int IdArea { get; set; }
        public DateTime? DayStart { get; set; }
        public DateTime? DayEnd { get; set; }
        public bool? IsActive { get; set; }
    }
}
