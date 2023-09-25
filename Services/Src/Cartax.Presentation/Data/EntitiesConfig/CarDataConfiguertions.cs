

using Cartax.Domain.Entites.Cars;
using Cartax.Presentation.Base;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class CarDataConfiguertions : BaseDataConfiguertions<Car>
    {

        public CarDataConfiguertions()
        {

            setData();
        }

        private void setData()
        {
            Data = new Car[]
            {

                Car.Create(1,1,"Car.A"),
                  Car.Create(2,2,"Car.B"),
                    Car.Create(3,3,"Car.C"),
                      Car.Create(4,4,"Car.D"),
                        Car.Create(5,5,"Car.F"),
                         Car.Create(6,6,"Car.H"),
                          Car.Create(7,7,"Car.X"),

            };
        }
    }
}
