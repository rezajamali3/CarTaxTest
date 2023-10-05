


using Cartax.Domain.Common.Errors;
using Cartax.Domain.Common.Model;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Domain.Tax.Aggregate;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Domain.Entites.Tax.TaxWeekDays;


namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCarArea : AggregateRoot
    {

        public CarType CarTypes { get; private set; }
        public TaxTime TaxTime { get; private set; }
        public TaxCarToday? TaxCarToday { get; private set; }
        public decimal LimaitTaxToday { get; private set; }
        public TaxWeekDayArea WeekDayArea { get; private set; }
        public TaxCar? TaxCarlast { get; private set; }
        public int TaxTimEnteraAndExit { get; private set; }
        public DateTime dateCreateRequst { get;  set; }
        public bool isHolidaysToday { get; private set; }
        public bool isHolidaysTomorrow { get; private set; }
        public bool isTaxTaxLongTermArea { get; private set; }
     



    public static TaxCarArea Create
            (
            CarType carType,
            List<TaxCar> taxCarToday,
            decimal limaitTaxToday,
            List<TaxWeekDay> weekDayArea,
            int taxTimEnteraAndExit,
            bool holidaysToday,
            bool holidaysTomorrow,
            bool taxTaxLongTermArea,
            TaxTime taxTime ,
            DateTime dateCreate
            )
        
            {


          
              var taxCarTo = new TaxCarToday(taxCarToday);
            TaxWeekDayArea WeekDayArea = new TaxWeekDayArea(weekDayArea);

           

            var taxCarArea = new TaxCarArea
            {
                TaxTime = taxTime,
                CarTypes       = carType,
                TaxCarToday    = taxCarTo,
                LimaitTaxToday = limaitTaxToday,
                WeekDayArea    = WeekDayArea,
                TaxTimEnteraAndExit  = taxTimEnteraAndExit,
                isHolidaysToday      = holidaysToday,
                isHolidaysTomorrow   = holidaysTomorrow,
                isTaxTaxLongTermArea = taxTaxLongTermArea,
                dateCreateRequst     = dateCreate
          };

            return taxCarArea;
        }



        public DomainResult TaxCarAreaContract()
        {

            DomainResult domainResult;

            #region Carincludingtax

            domainResult = Carincludingtax();
            if (domainResult.IsSuccess == false)
                return domainResult;

            #endregion

            #region Days including tax
            domainResult = Daysincludingtax();
            if (domainResult.IsSuccess == false)
                return domainResult;
            #endregion Days Including tax


            #region Exempted from disability during a certain period of time

            if (isTaxTaxLongTermArea == true)
            {
                domainResult.SetData(false, DomainError.DomainTaxCar.TaxLongTermArea);
                return domainResult;
            }

            #endregion Exempted from disability during a certain period of time


            #region Holidays Today

            if (isHolidaysToday == true)
            {
                domainResult.SetData(false, DomainError.DomainTaxCar.HolidaysToday);
                return domainResult;
            }

            #endregion Holidays Today

            #region HolidaysTomorrow

            if (isHolidaysTomorrow == true)
            {
                domainResult.SetData(false, DomainError.DomainTaxCar.HolidaysTomorrow);
                return domainResult;
            }

            #endregion HolidaysTomorrow

            #region The time limit until the previous tax

            domainResult = Thetimelimituntiltheprevioustax();
            if (domainResult.IsSuccess == false)
                return domainResult;

            #endregion The time limit until the previous tax

            #region Todaystaxceiling
            domainResult = Todaystaxceiling();
            if (domainResult.IsSuccess == false)
                return domainResult;
            #endregion Todaystaxceiling

            #region  Calculator Tax
          
            var CalculatorTax =  TaxCarCalculatorMoney.Create(TaxCarToday, LimaitTaxToday, TaxTime.Tax);
            domainResult.Data= CalculatorTax.CalculatorMoney();
            
            #endregion  Calculator Tax

            
            
            
            return domainResult;

        }

        //ماشین های شامل
        private DomainResult Carincludingtax()
        {
            if (CarTypes is null)
                return new DomainResult(false, DomainError.DomainTaxCar.CarTypesNull);

            var ludingtax =new CarTypeincludingtax(CarTypes);
           var IsSuccuss = ludingtax.Carincludingtax();
            if (IsSuccuss == false)
                return new DomainResult(false, DomainError.DomainTaxCar.CarTypesNoTax);
            return new DomainResult(true, DomainError.DomainTaxCar.CarTaxNone);
        }

        // حد مقدار تکست امروز
        private DomainResult Todaystaxceiling()
        {

            if (TaxTime is null)
                return new DomainResult(false, DomainError.DomainTaxCar.CarTypesTaxTimeNull);

            if (TaxCarToday.GetAll() is null)
                return new DomainResult(true, DomainError.DomainTaxCar.TaxCarlastTodayNull);

            if (LimaitTaxToday == 0)
                return new DomainResult(true, DomainError.DomainTaxCar.LimaitTaxTodayZero);

            var TodaystaxceilingToday =new TaxCarsTodaystaxceilingToday(TaxCarToday, LimaitTaxToday,(decimal) TaxTime.Tax);
            var IsSuccuss = TodaystaxceilingToday.TodaystaxceilingToday();
           
            if (IsSuccuss == true)
                return new DomainResult(true, DomainError.DomainTaxCar.CarTaxNone);

            return new DomainResult(false, DomainError.DomainTaxCar.Todaystaxceiling);
        }

        //روز های شامل مالیات
        private DomainResult Daysincludingtax()
        {
            if (WeekDayArea.GetAll() is null)
                return new DomainResult(true, DomainError.DomainTaxCar.WeekDayAreaNull);

            var taxWeekDaysincludingtax = TaxWeekDaysincludingtax.Create(WeekDayArea, dateCreateRequst);
            var IsSuccuss = taxWeekDaysincludingtax.Daysincludingtax();
            if (IsSuccuss == true)
                return new DomainResult(true, DomainError.DomainTaxCar.CarTaxNone);
            return new DomainResult(false, DomainError.DomainTaxCar.WeekDayAreaNoTax);
        }

        //مالیات در بازه زمانی مشخص
        private DomainResult Thetimelimituntiltheprevioustax()
        {

            if (TaxTimEnteraAndExit == 0)
                return new DomainResult(true, DomainError.DomainTaxCar.TaxCarlastTaxNotLimait);

            if (TaxCarlast is null)
                return new DomainResult(true, DomainError.DomainTaxCar.TaxCarlastTodayNull);

            var taxWeekDaysincludingtax = TaxTimeThetimelimituntiltheprevioustax.Create(TaxCarlast, TaxTimEnteraAndExit, dateCreateRequst);
            var IsSuccuss = taxWeekDaysincludingtax.Thetimelimituntiltheprevioustax();
            if (IsSuccuss == true)
                return new DomainResult(true, DomainError.DomainTaxCar.CarTaxNone);
            return new DomainResult(false, DomainError.DomainTaxCar.TaxCarlastTodayNotContanTax);
        }
    }

}

