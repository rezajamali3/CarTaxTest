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
    public class TaxTimeDataConfiguertions :BaseDataConfiguertions<TaxTime>
    {

        public TaxTimeDataConfiguertions()
        {

            setData();
        }

        private void setData()
        {
            Data = new TaxTime[]
            {

                TaxTime.Create(1,new TimeSpan(6,0,0),new TimeSpan(6,29,00),1,8),
                  TaxTime.Create(2,new TimeSpan(6,30,0),new TimeSpan(6,59,00),1,13),
                  TaxTime.Create(3,new TimeSpan(7,0,0),new TimeSpan(7,59,00),1,18),
                   TaxTime.Create(4,new TimeSpan(8,0,0),new TimeSpan(8,29,00),1,13),
                    TaxTime.Create(5,new TimeSpan(8,30,0),new TimeSpan(14,59,00),1,18),
                     TaxTime.Create(6,new TimeSpan(15,00,0),new TimeSpan(15,29,00),1,13),
                      TaxTime.Create(7,new TimeSpan(15,30,0),new TimeSpan(16,59,00),1,18),
                        TaxTime.Create(8,new TimeSpan(17,00,0),new TimeSpan(17,59,00),1,13),
                        TaxTime.Create(9,new TimeSpan(18,00,0),new TimeSpan(18,29,00),1,8),
                        TaxTime.Create(10,new TimeSpan(18,30,0),new TimeSpan(23,59,59),1,8),
                         TaxTime.Create(11,new TimeSpan(00,00,0),new TimeSpan(05,59,00),1,8),
            };
        }
    }
}
