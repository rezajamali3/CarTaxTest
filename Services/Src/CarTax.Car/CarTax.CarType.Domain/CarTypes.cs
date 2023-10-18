
using CarTax.CarType.Domain.ValueObjects;
using CarTax.CarType.Message;
using Library_Domain.Model;

namespace CarTax.CarType.Domain
{

    public class CarTypes : AggregateRoot<CarTypeId>
    {
       

        public CarTypes(CarTypeId id)
            : base(id) { }

        private CarTypes(CarTypeId id, TypeCarName nameTypeCar, bool isActive, bool isTaxActive)
            : base(id)
        {

            TypeCarName = nameTypeCar;
            IsActive = isActive;
            IsTaxActive = isTaxActive;

        }


        #region Behavior

        public static CarTypes Create(CarTypeId id, TypeCarName carName, bool isActive, bool isTaxActive)
        {
            var carType = new CarTypes(id);

            carType.Apply(new Events.V1.NewTaxCarType
            {
                id = id.Value,
                carName = carName.Value,
                isActive = isActive,
                isTaxActive = isTaxActive
            }
            );

            return carType;
        }

        public void TaxCarTypeCarName(string carName) => Apply(new Events.V1.ChancheCarTypeName { carName = carName });

        public void TaxCarTypeActive()      => Apply(new Events.V1.TaxCarTypeActive { });

        public void TaxCarTypeDeActive()    => Apply(new Events.V1.TaxCarTypeDeActive {  });

        public void TaxCarTypeTaxActive()   => Apply(new Events.V1.TaxCarTypeTaxActive {  });

        public void TaxCarTypeDeTaxActive() => Apply(new Events.V1.TaxCarTypeTaxDeActive {  });

        public void TaxCarTypeDelete()      => Apply(new Events.V1.TaxCarTypeDelete { });

        #endregion Behavior

        protected override void When(object @event)
        {
            switch (@event)
            {

                case Events.V1.NewTaxCarType e:

                    State = CarTypesState.Create;

                    break;

                case Events.V1.TaxCarTypeDelete e:
                    State = CarTypesState.Delete;

                    break;

                case Events.V1.ChancheCarTypeName e:
                    TypeCarName = TypeCarName.Create(Name.Create(e.carName));
                    State = CarTypesState.ChanchName;
                    break;

                case Events.V1.TaxCarTypeActive e:
                    IsActive = true;
                    State = CarTypesState.Active;
                    break;

                case Events.V1.TaxCarTypeDeActive e:
                    IsActive = false;
                    State = CarTypesState.DeActive;
                    break;

                case Events.V1.TaxCarTypeTaxActive e:
                    IsTaxActive = true;
                    State = CarTypesState.Tax;
                    break;

                case Events.V1.TaxCarTypeTaxDeActive e:
                    IsTaxActive = false;
                    State = CarTypesState.NoTax;
                    break;

            }
        }

        protected override void EnsureValidState()
        {
            var valid =
              Id is not null &&  TypeCarName is not null &&
              (State switch
              {
                  
                  CarTypesState.Active => IsActive == true ,
                  CarTypesState.DeActive => IsActive == false,
                  CarTypesState.Tax => IsTaxActive == true,
                  CarTypesState.NoTax => IsTaxActive == false,
                  _ => true
              });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $"Post-checks failed in state {State}"
                );
        }

        #region Prpertiy

        public TypeCarName TypeCarName { get; private set; }

        public bool? IsActive { get; private set; }

        public bool? IsTaxActive { get; private set; }

        public CarTypesState State { get; private set; }

        #endregion Prpertiy



        public enum CarTypesState
        {
            Create, ChanchName, Active, DeActive, Tax, NoTax, Delete
        }

    }
}
