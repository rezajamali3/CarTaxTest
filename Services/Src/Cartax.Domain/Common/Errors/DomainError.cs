using Cartax.Domain.Common.Enume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Common.Errors
{
    public static class DomainError
    {
        public static class DomainTaxCar
        {
            public static readonly Error CarTaxNone = new(ErrorTypes.Domain, "شامل مالیات است", (int)ErrorDomainTypes.CarTaxNone);
            public static readonly Error CarTypesNull = new(ErrorTypes.Domain, "مقدار ورودی نوع ماشین نامعتبر است", (int)ErrorDomainTypes.CarTypesNull);
            public static readonly Error CarTypesNoTax = new(ErrorTypes.Domain, "ماشین شامل مالیات نیست", (int)ErrorDomainTypes.CarTypesNoTax);
            public static readonly Error CarTypesTaxTimeNull = new(ErrorTypes.Domain, "این ساعت شامل مالیات نیست ", (int)ErrorDomainTypes.CarTypesTaxTimeNull);
            public static readonly Error LimaitTaxTodayZero = new(ErrorTypes.Domain, "این منطقه شامل محدوید سقف مالیات نیست", (int)ErrorDomainTypes.LimaitTaxTodayZero);
            public static readonly Error Todaystaxceiling = new(ErrorTypes.Domain, "از سقف مجاز مالیات روزانه بیشتر است", (int)ErrorDomainTypes.Todaystaxceiling);
            public static readonly Error WeekDayAreaNull = new(ErrorTypes.Domain, "روزی برای مالیات ندارد این منطقه", (int)ErrorDomainTypes.WeekDayAreaNull);
            public static readonly Error WeekDayAreaNoTax = new(ErrorTypes.Domain, "شامل مالیات روزهای هفته نیست", (int)ErrorDomainTypes.WeekDayAreaNoTax);
            public static readonly Error TaxCarlastTaxNotLimait = new(ErrorTypes.Domain, "این منطقه شامل مالیت زمانی نمی شود", (int)ErrorDomainTypes.TaxCarlastTaxNotLimait);
            public static readonly Error TaxCarlastTodayNull = new(ErrorTypes.Domain, "این ماشین امروز مالیات نداشته است", (int)ErrorDomainTypes.TaxCarlastTodayNull);
            public static readonly Error TaxCarlastTodayNotContanTax = new(ErrorTypes.Domain, "مدت زمان کمتر از زمان تعیین شده تا مالیات بعدی است", (int)ErrorDomainTypes.TaxCarlastTodayNotContanTax);


            public static readonly Error HolidaysToday = new(ErrorTypes.Domain, "امروز تعطیات عمومی است", (int)ErrorDomainTypes.HolidaysToday);
            public static readonly Error HolidaysTomorrow = new(ErrorTypes.Domain, "فردا تعطیلات رسمی است شامل مالیات نمی شود", (int)ErrorDomainTypes.HolidaysTomorrow);
            public static readonly Error TaxLongTermArea = new(ErrorTypes.Domain, "مافیت زمانی از مالیات زمان بندی خاص", (int)ErrorDomainTypes.TaxLongTermArea);
        }
    }
}
