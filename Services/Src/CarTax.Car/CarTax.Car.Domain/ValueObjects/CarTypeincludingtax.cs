using CarTax.Car.Domain.Entitys;
using Library_Domain.Model;

namespace CarTax.Car.Domain.ValueObjects
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
