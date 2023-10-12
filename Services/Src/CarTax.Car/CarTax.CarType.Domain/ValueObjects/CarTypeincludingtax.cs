
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Domain.ValueObjects
{
    public class CarTypeincludingtax : ValueObject<CarTypeincludingtax>
    {
        public CarTypes CarTypes { get; private set; }

        public CarTypeincludingtax(CarTypes carTypes)
        {
            CarTypes = carTypes;
        }

        public static CarTypeincludingtax Create(CarTypes carTypes)
        {
            return new CarTypeincludingtax(carTypes);
        }


        public bool? Carincludingtax()
        {
            return CarTypes.IsTaxActive;
        }



        public override IEnumerable<object> GetAtomicValues()
        {
            yield return CarTypes;
        }


    }
}
