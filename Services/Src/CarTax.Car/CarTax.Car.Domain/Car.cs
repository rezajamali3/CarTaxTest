using CarTax.Car.Domain.Entitys;
using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Model;

namespace CarTax.Car.Domain.Root
{
    public class Cars : Entity<CarId?>
    {

        private Cars(CarId? id) : base(id)
        {

        }

        private Cars(CarId? id, CarType carType, NameCar carName) : base(id)
        {

            CarType = carType;
            CarName = carName;
        }

        public static Cars Create(CarId? id, CarType CarType, NameCar carName)
        {
            var car = new Cars(id, CarType, carName);
            return car;
        }

        public CarType? CarType { get; private set; }

        public NameCar CarName { get; private set; }




    }
}
