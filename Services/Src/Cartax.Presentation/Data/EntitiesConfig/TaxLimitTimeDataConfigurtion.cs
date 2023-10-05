
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
    public class TaxLimitTimeDataConfigurtion : BaseDataConfiguertions<TaxLimitTime>
    {

        public TaxLimitTimeDataConfigurtion()
        {

            setData();
        }

        private void setData()
        {
            var city = City.Create(1, "تهران", "آزاد");
            var area = Area.Create(1, "جنوب", "...", city);
            Data = new TaxLimitTime[]
            {

                //TaxLimitTime.Create(1,TimeSpan.FromMinutes(60),area),
                 

            };
        }
    }
}


