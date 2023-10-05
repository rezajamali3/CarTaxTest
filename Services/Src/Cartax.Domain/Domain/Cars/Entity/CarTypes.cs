

using Cartax.Domain.Common.Model;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Cars;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.CarTypes
{



    public class CarType : Entity
    {



        private CarType(int? Id) : base(Id)
        {

        }

        private CarType(int? id, string carName,bool isActive, bool isTaxActive, City city) : base(id)
        {
          
            CarName = carName;
            IsActive = isActive;
            IsTaxActive = isTaxActive;
            City = city;

        }

      
        public string CarName { get; private set; }

        public City City { get; private set; }

        public bool? IsActive { get; private set; }

        public bool? IsTaxActive { get; private set; }

        public static CarType Create(int? id, City city, string carName, bool isActive,bool isTaxActive)
        {
            var car = new CarType(id, carName, isActive, isTaxActive, city);
            return car;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }


        public void TaxDeactivate()
        {
            IsTaxActive = false;
        }

        public void TaxActivate()
        {
            IsTaxActive = true;
        }


       
        public ICollection<Car> Cars { get; }
    }
}
