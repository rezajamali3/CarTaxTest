using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxLongTerms
{
    public class TaxTaxLongTermUpdateDTO : BaseDTO
    {
        public int? Id { get; set; }
        public int IdArea { get; set; }
        public DateTime? DayStart { get; set; }
        public DateTime? DayEnd { get; set; }
        public bool? IsActive { get; set; }
    }
}
