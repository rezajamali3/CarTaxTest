
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
    public class TaxTaxLongTermDataConfiguertion : BaseDataConfiguertions<TaxTaxLongTerm>
    {

        public TaxTaxLongTermDataConfiguertion()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxTaxLongTerm[]
            {

                //TaxTaxLongTerm.Create(1,1,new DateTime(2013,07,01),new DateTime(2013,07,30))
               
            };
        }
    }
}

