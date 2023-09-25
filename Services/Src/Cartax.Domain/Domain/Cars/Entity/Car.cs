
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

        private Car(int? id, int idcarType, string carName) : base(id)
        {

            IdCarType = idcarType;
            CarName = carName;
        }



        public int? IdCarType { get; private set ; }
      
        public string CarName { get; private set; }



        public static Car Create(int? id, int IdCarType, string carName)
        {
            var car =  new Car(id, IdCarType, carName);
            return car;
        }

        public CarType CarType { get; }
        public ICollection<TaxCar> TaxCars { get; private set; }

    }
}
