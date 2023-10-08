using Cartax.Domain.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxWeekDays
{
    public class TaxWeekDaysincludingtax : ValueObject
    {

       
        private TaxWeekDayArea? WeekTypes { get; set; }
        private DateTime DateCreate { get; set; }

        private TaxWeekDaysincludingtax(TaxWeekDayArea? weekTypes, DateTime dateCreate)
        {
            WeekTypes = weekTypes;
            DateCreate = dateCreate;
        }


        public static TaxWeekDaysincludingtax Create(TaxWeekDayArea? weekTypes,DateTime dateCreate)
        {
            return new TaxWeekDaysincludingtax(weekTypes, dateCreate);
        }


        public bool Daysincludingtax()
        {

            int day = GetWeekDay();
            foreach (var weekType in WeekTypes.GetAll())
            {
                if(day== weekType.DatyTyps)
                    return false;
            }

            return true;
              
        }


        private int GetWeekDay()
        {
            DayOfWeek dayOfWeek = DateCreate.DayOfWeek;
            return (int)dayOfWeek;
        }


        public override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }


    }
}
