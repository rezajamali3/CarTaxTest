using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Common.Enume
{
    public enum ErrorDomainTypes
    {
        CarTaxNone = 0,
        CarTypesNull = 1,
        CarTypesNoTax = 2,
        CarTypesTaxTimeNull = 3,
        LimaitTaxTodayZero = 4,
        Todaystaxceiling = 5,
        WeekDayAreaNull = 6,
        WeekDayAreaNoTax = 7,
        TaxCarlastTaxNotLimait = 8,
        TaxCarlastTodayNull = 9,
        TaxCarlastTodayNotContanTax = 10,
        HolidaysToday = 11,
        HolidaysTomorrow = 12,
        TaxLongTermArea = 13
    }
}
