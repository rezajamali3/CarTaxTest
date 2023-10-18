using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Interface;
using Library_Domain.Model;
using CarTax.Car.Message;
using NPOI.OpenXmlFormats.Dml.Diagram;
using CarTax.CarType.Domain.ValueObjects;
using static CarTax.CarType.Domain.CarTypes;
using CarTax.CarType.Domain;

namespace CarTax.Car.Domain
{
    public class Cars : AggregateRoot<CarId>
    {

        public enum CarState
        {
            Create,Chanch,  Active, DeActive, Delete
        }



        private Cars(CarId? id) : base(id)
        {

        }

        private Cars(CarId? id, byte carTypeId, CarName carName, Plack plack, bool isActive) : base(id)
        {
            Plack = plack;
            IsActive = isActive;
            CarTypeId = carTypeId;
            CarName = carName;

        }

        #region Behavior

        public static Cars Create(CarId? id, byte carTypeId, CarName carName, Plack plack, bool isActive)
        {

            var car = new Cars( id );

            car.Apply(new Events.V1.NewCar
            {
                Id = id.Value,
                CarName = carName.Value,
                CarTypeId = carTypeId,
                CodePlack = plack.CodePlack,
                NumberPlack = plack.NumberPlack,
                IsActive = isActive,
            } );

            return car;
           
        }

        public void ChanchDetilsCar(int? id, byte carTypeId, string carName, string codePlack,string numberPlack, bool isActive)
        => Apply(new Events.V1.ChanchDetailsCar
            {
                Id = id.Value,
                CarName = carName,
                CarTypeId = carTypeId,
                CodePlack = codePlack,
                NumberPlack = numberPlack,
                IsActive = isActive,
            });

        public void CarActive()
         => Apply(new Events.V1.CarActive());

        public void CarDeActive()
        => Apply(new Events.V1.CarDeActive());

        public void CarDelete()
         => Apply(new Events.V1.CarDelete());

        #endregion Behavior

        protected override void When(object @event)
        {
           switch (@event)
            {



                case Events.V1.NewCar e:
                    CarTypeId = e.CarTypeId;
                    Plack = Plack.Create(e.CodePlack, e.NumberPlack);
                    IsActive = e.IsActive;
                    CarName = CarName.Create(ValueObjects.Name.Create( e.CarName));
                    State = CarState.Create;
                    break;

                case Events.V1.ChanchDetailsCar e:
                    CarName = CarName.Create(ValueObjects.Name.Create(e.CarName));
                    CarTypeId = e.CarTypeId;
                    Plack = Plack.Create(e.CodePlack, e.NumberPlack);
                    IsActive = e.IsActive;
                    State = CarState.Chanch;
                    break;

                case Events.V1.CarActive e:

                    IsActive = true;
                    State = CarState.Active;

                    break;

                case Events.V1.CarDeActive e:

                    IsActive = false;
                    State = CarState.DeActive;

                    break;

                case Events.V1.CarDelete e:

                    IsActive = true;
                    State = CarState.Delete;

                    break;
            }
        }

        protected override void EnsureValidState()
        {
            var valid =
             Id is not null && CarName is not null &&
             (State switch
             {

                 CarState.Active => IsActive == true,
                 CarState.DeActive => IsActive == false,
                
                 _ => true
             });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $"Post-checks failed in state {State}"
                );
        }


        #region Properti

        public byte CarTypeId { get; private set; }

        public CarName CarName { get; private set; }

        public Plack Plack { get; private set; }

        public bool IsActive { get; private set; }

        public CarState  State { get; private set; }

        #endregion Properti

    }
}
