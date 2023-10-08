using CarTax.Car.Domain.Root;
using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Model;
using Library_Domain.Model;

namespace CarTax.Car.Domain.Entitys
{

    public class CarType : Entity<CarTypeId?>
    {


        private CarType(CarTypeId? Id) : base(Id)
        {

        }

        private CarType(CarTypeId? id, NameTypeCar nameTypeCar, bool isActive, bool isTaxActive) : base(id)
        {

            NameTypeCar = nameTypeCar;
            IsActive = isActive;
            IsTaxActive = isTaxActive;

        }




        public static CarType Create(CarTypeId? id, NameTypeCar carName, bool isActive, bool isTaxActive)
        {
            var car = new CarType(id, carName, isActive, isTaxActive);
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

        public NameTypeCar NameTypeCar { get; private set; }

        public bool? IsActive { get; private set; }

        public bool? IsTaxActive { get; private set; }

        private List<Cars> _Cars = new();
        public IReadOnlyList<Cars> Cars => _Cars.ToList();
    }
}
