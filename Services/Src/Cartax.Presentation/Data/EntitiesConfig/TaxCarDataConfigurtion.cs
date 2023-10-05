using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxCarDataConfigurtion : BaseDataConfiguertions<TaxCar>
    {

        public TaxCarDataConfigurtion()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxCar[]
            {

               

            };
        }
    }
}


