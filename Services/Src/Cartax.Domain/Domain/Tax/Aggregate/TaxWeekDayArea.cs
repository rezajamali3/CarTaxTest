using Cartax.Domain.Common.Base;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Tax.Aggregate
{
    public class TaxWeekDayArea : Aggregate<TaxWeekDay>
    {
        public TaxWeekDayArea(List<TaxWeekDay>? taxWeekDays) : base(taxWeekDays)
        {
        }
    }
}
