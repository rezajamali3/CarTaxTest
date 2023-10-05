

using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Cars;
using Cartax.Domain.Entites.CarTypes;
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
            //Normal = 1,
            //Emergency = 2,
            //Busses = 3,
            //Diplomat = 4,
            //Motorcycles = 5,
            //Military = 6,
            //Foreign = 7
            var city = City.Create(1, "تهران", "آزاد");
            CarType Normal = CarType.Create(1, city, "Normal", true, true);
            CarType Emergency = CarType.Create(2, city, "Emergency", true, true);
            CarType Busses = CarType.Create(2, city, "Busses", true, true);
            CarType Diplomat = CarType.Create(2, city, "Diplomat", true, true);
            CarType Motorcycles = CarType.Create(2, city, "Motorcycles", true, true);
            CarType Military = CarType.Create(2, city, "Military", true, true);
            CarType Foreign = CarType.Create(2, city, "Foreign", true, true);
         

            Data = new Car[]
            {

                //Car.Create(1,Normal,"Car.A"),
                //  Car.Create(2,Emergency,"Car.B"),
                //    Car.Create(3,Busses,"Car.C"),
                //      Car.Create(4,Diplomat,"Car.D"),
                //        Car.Create(5,Motorcycles,"Car.F"),
                //         Car.Create(6,Military,"Car.H"),
                //          Car.Create(7,Foreign,"Car.X"),

            };
        }
    }
}
