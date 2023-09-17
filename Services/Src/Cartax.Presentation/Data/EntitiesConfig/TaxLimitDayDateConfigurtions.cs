using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxLimitDayDateConfigurtions : BaseDataConfiguertions<TaxLimitDay>
    {

        public TaxLimitDayDateConfigurtions()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxLimitDay[]
            {

                TaxLimitDay.Create(1,new TimeSpan(0,59,0),1),
                

            };
        }
    }
}

