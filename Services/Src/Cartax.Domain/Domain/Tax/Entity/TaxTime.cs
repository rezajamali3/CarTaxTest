using Cartax.Domain.Base;

using Cartax.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Entites.Areas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cartax.Domain.Entites.Tax.TaxTimes
{
    public class TaxTime : Entity
    {
        public TimeSpan? StartDate { get; private set; }
        public TimeSpan? EndDate { get; private set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tax { get; private set; }

        public int? Idarea { get; private set; }

        private TaxTime(int? id) : base(id)
        {
        
        }


        private TaxTime(int? id, TimeSpan startDate, TimeSpan endDate, int idarea, decimal tax) : base(id)
        {
            StartDate = startDate;
            EndDate = endDate;
            Idarea = idarea;
            Tax = tax;
        }

        public static TaxTime Create(int? id, TimeSpan startDate, TimeSpan endDate, int idarea, decimal tax)
        {

            if (startDate > endDate)
                throw new ArgumentException("تاریخ شروع باید قبل از تاریخ پایان باشد.");

            return new TaxTime(id, startDate, endDate, idarea, tax);
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
