using Cartax.Domain.Common.Base;
using Cartax.Domain.Entites.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.CarTypes
{
    public class CarTypeincludingtax : ValueObject
    {
        public CarType CarTypes { get; private set; }
      
        public CarTypeincludingtax(CarType carTypes)
        {
            CarTypes = carTypes;
        }

        public static CarTypeincludingtax Create(CarType carTypes)
        {
            return new CarTypeincludingtax( carTypes);
        }


       public bool?  Carincludingtax()
        {
            return CarTypes.IsTaxActive;
        }
 


        public override IEnumerable<object> GetAtomicValues()
        {
            yield return CarTypes;
        }
    }
}
