
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Cars;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxLimitMoneyDayConfiguare : BaseDataConfiguertions<TaxLimitMoneyDay>
    {

        public TaxLimitMoneyDayConfiguare()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxLimitMoneyDay[]
            {

                TaxLimitMoneyDay.Create(1,60,1)
                 

            };
        }
    }
}

