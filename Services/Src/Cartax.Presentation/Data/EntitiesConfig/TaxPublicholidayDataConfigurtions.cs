using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxPublicholidayDataConfigurtions : BaseDataConfiguertions<TaxPublicholiday>
    {

        public TaxPublicholidayDataConfigurtions()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxPublicholiday[]
            {

                TaxPublicholiday.Create(1,DateTime.Now.AddDays(2)),
                

            };
        }
    }
}


