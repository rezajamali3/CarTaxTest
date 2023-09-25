using Cartax.Domain.Base;
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

        private CarType(int? id, string carName,bool isActive, bool isTaxActive, int idcity) : base(id)
        {
          
            CarName = carName;
            IsActive = isActive;
            IsTaxActive = isTaxActive;
            Idcity = idcity;
        }

      
        public string CarName { get; private set; }


        public int Idcity { get; private set; }

        
        public bool? IsActive { get; private set; }




        public bool? IsTaxActive { get; private set; }


        public static CarType Create(int? id, int carType, int idcity, string carName, bool isActive,bool isTaxActive)
        {
            var car = new CarType(id, carName, isActive, isTaxActive,  idcity);
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

    }
}
