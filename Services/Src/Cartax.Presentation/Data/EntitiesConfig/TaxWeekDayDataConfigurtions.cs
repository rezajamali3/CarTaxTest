using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Cartax.Domain.Sharid.Enume;
using Cartax.Presentation.Base;
using System;
using Cartax.Presentation.Data.EntitiesConfig;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxWeekDayDataConfigurtions : BaseDataConfiguertions<TaxWeekDay>
    {

        public TaxWeekDayDataConfigurtions()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxWeekDay[]
            {

                TaxWeekDay.Create(1,(int)WeekDayTypes.Saturday,10,true,1),
                TaxWeekDay.Create(2,(int)WeekDayTypes.Sunday,10,true,1)

            };
        }
    }
}


