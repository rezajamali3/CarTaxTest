﻿using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxLimitTimes;
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
            Data = new TaxLimitTime[]
            {

                TaxLimitTime.Create(1,TimeSpan.FromMinutes(60)),
                 

            };
        }
    }
}


