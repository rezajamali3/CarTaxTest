

using Cartax.Domain.Common.Model;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Tax.TaxCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Cars
{
    public class Car : Entity
    {

        private Car(int? id) : base(id)
        {
          
        }

        private Car(int? id, CarType carType, string carName) : base(id)
        {

            CarType = carType;
            CarName = carName;
        }



        public CarType CarType { get; private set; }

        public string CarName { get; private set; }


        public static Car Create(int? id, CarType carTyp, string carName)
        {
            var car =  new Car(id, carTyp, carName);
            return car;
        }

      
        public ICollection<TaxCar> TaxCars { get; private set; }

    }
}
