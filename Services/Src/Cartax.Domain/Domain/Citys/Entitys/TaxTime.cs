

using Library_Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;



namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxTime : Entity<int?>
    {
        public TimeSpan? StartDate { get; private set; }
        public TimeSpan? EndDate { get; private set; }

      
        public decimal? Tax { get; private set; }

        public Area Area { get; private set; }

        private TaxTime(int? id) : base(id)
        {
        
        }


        private TaxTime(int? id, TimeSpan startDate, TimeSpan endDate, Area area, decimal tax) : base(id)
        {
            StartDate = startDate;
            EndDate = endDate;
            Area = area;
            Tax = tax;
        }

        public static TaxTime Create(int? id, TimeSpan startDate, TimeSpan endDate, Area area, decimal tax)
        {

            if (startDate > endDate)
                throw new ArgumentException("تاریخ شروع باید قبل از تاریخ پایان باشد.");

            return new TaxTime(id, startDate, endDate, area, tax);
        }

        public void ChangeStartDate(TimeSpan newStartDate)
        {

            if (newStartDate > EndDate)
                throw new ArgumentException("تاریخ شروع باید قبل از تاریخ پایان باشد.");

            StartDate = newStartDate;
        }

        public void ChangeEndDate(TimeSpan newEndDate)
        {

            if (newEndDate < StartDate)
                throw new ArgumentException("تاریخ پایان باید بعد از تاریخ شروع باشد.");

            EndDate = newEndDate;
        }

        public void ChangeTax(decimal tax)
        {
            Tax = tax;
        }

       
    }

}
