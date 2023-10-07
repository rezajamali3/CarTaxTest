using Cartax.Domain.Entites.Cars;
using Cartax.Presentation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxCarDataConfigurtion : BaseDataConfiguertions<Car>
    {

        public TaxCarDataConfigurtion()
        {

            setData();
        }

        private void setData()
        {
            Data = new Car[]
            {

                Car.Create(1,1,"Normal"),
                  Car.Create(2,2,"Emergency"),
                    Car.Create(3,3,"Busses"),
                      Car.Create(4,4,"Diplomat"),
                        Car.Create(5,5,"Motorcycles"),
                         Car.Create(6,6,"Military"),
                          Car.Create(7,7,"Foreign"),

            };
        }
    }
}


