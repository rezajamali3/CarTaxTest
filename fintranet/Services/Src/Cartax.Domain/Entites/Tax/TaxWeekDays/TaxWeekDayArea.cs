using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxWeekDays
{
    public class TaxWeekDayArea : Aggregate<TaxWeekDay>
    {
        public TaxWeekDayArea(List<TaxWeekDay>? taxWeekDays): base(taxWeekDays)
        { 
        }
    }
}
