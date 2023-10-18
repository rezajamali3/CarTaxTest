

using CarTax.City.Domain.ValueObjects;
using CarTax.City.Message;
using Library_Domain.Model;


namespace CarTax.City.Domain
{
    public class Citys : AggregateRoot<CityId>
    {



        public Citys() { }

        private Citys(CityId? Id) : base(Id) { }

        private Citys(CityId Id, CityName cityName, CityCode cityCode, bool isActive) : base(Id)
        {
            CityName = cityName;
            CityCode = cityCode;
            IsActive = isActive;
        }

        #region Property

        public CityName CityName { get; private set; }

        public  CityCode   CityCode   { get; private set; }

        public  bool      IsActive   { get; private set; }

        public  CityState State { get; private set; }

        #endregion Property

        #region Behavior

        public static Citys Create( CityName cityName, CityCode cityCode,bool isActive)
        {
            var city = new Citys()
            {
             
                CityName = cityName,
                CityCode =  cityCode,
                IsActive = isActive
            };

            city.Apply(city);

            return city;
        }

        public void ChancheCity( string cityName,string cityCode, bool isActive)
        => Apply(new Events.V1.ChanchDetailsCity
        {
            CityName=cityName,
            CityCode=cityCode,
            IsActive=isActive
        }
        );

        public void CityActive()
        => Apply(new Events.V1.CityActive ());

        public void CityDeActive()
        => Apply(new Events.V1.CityDeActive());

        public void CityDelete()
        => Apply(new Events.V1.CityDelete());

        #endregion Behavior

        #region Chack State
        protected override void When(object @event)
        {
            switch (@event)
            {
                case Events.V1.NewCity e:

                    State = CityState.Create;
                    break;
                case Events.V1.ChanchDetailsCity e:
                    
                    CityName = CityName.Create(Name.Create( e.CityName));
                    CityCode = CityCode.Create(e.CityCode);
                    IsActive = e.IsActive;

                    State = CityState.Chanch;
                    break;

                case Events.V1.CityActive  e:

                    State = CityState.Active;
                    break;

                case Events.V1.CityDeActive  e:

                    State = CityState.DeActive;
                    break;

                case Events.V1.CityDelete e:

                    State = CityState.Delete;
                    break;

            };
        }


        protected override void EnsureValidState()
        {
            var valid = Id  is not null && CityName is not null && CityCode is not null
               &&  (State switch
                 {

                     CityState.Active => IsActive == true,
                     CityState.DeActive => IsActive == false,

                     _ => true
                 });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $"Post-checks failed in state {State}"
                );
        }

        public enum CityState
        {
            Create, Chanch, Active, DeActive, Delete
        }

        #endregion  Chack State
    }
}
