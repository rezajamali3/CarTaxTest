
using CarTax.Taxfreecar.Domain.ValueObjects;
using CarTax.Taxfreecar.Message;
using Library_Domain.Model;


namespace CarTax.AggregateRoot
{

    public class TaxFreeCar : AggregateRoot<TaxfreecarId>
    {

        #region Constructor
      
        protected TaxFreeCar(TaxfreecarId id)
            : base(id) { }

        private TaxFreeCar(int idArea,int typeCarId, bool isActive)
            : base(default)
        {
            TypeCarId = typeCarId;
            AreaId = idArea;
            IsActive = isActive;
           

        }

        #endregion Constructor

        #region Prpertiy

        public int AreaId { get; private set; }

        public int TypeCarId { get; private set; }

        public bool? IsActive { get; private set; }

        public TaxfreeState State { get; private set; }

        #endregion Prpertiy

        #region Behavior


        public static TaxFreeCar Create(int areaId,int TypeCarId, bool isActive)
        {
            var taxfreecar = new TaxFreeCar(default);

            taxfreecar.Apply(new Events.V1.NewTaxfreecar
            {
                TypeCarId= TypeCarId,
                AreaId = areaId,
                IsActive = isActive,
            }
            );

            return taxfreecar;
        }

        public void ChancheTaxfreecar(int id,int areaId, int TypeCarId, bool isActive) =>
         Apply(new Events.V1.ChancheTaxfreecar 
        { 
            Id =  id,
            AreaId = areaId,
            IsActive=isActive
        });

        public void TaxfreecarActive()      => Apply(new Events.V1.TaxfreecarActive {
            Id = this.Id.Value
        });

        public void TaxfreecarDeActive()    => Apply(new Events.V1.TaxfreecarDeActive { 
            Id=this.Id.Value
        
        });

        public void TaxfreecarDelete()      => 
            Apply(new Events.V1.TaxfreecarDelete { });

        #endregion Behavior

        #region Status check

        protected override void When(object @event)
        {
            switch (@event)
            {

                case Events.V1.NewTaxfreecar e:
                    AreaId = e.AreaId;
                    IsActive = e.IsActive;
                    State = TaxfreeState.Create;
                    break;

                case Events.V1.ChancheTaxfreecar e:

                    AreaId = e.AreaId;
                    IsActive = e.IsActive;
                    State = TaxfreeState.Chanch;
                    break;

                case Events.V1.TaxfreecarActive e:
                    IsActive = true;
                    State = TaxfreeState.Active;
                    break;

                case Events.V1.TaxfreecarDeActive e:
                    IsActive = false;
                    State = TaxfreeState.DeActive;
                    break;

                case Events.V1.TaxfreecarDelete e:
                  
                    State = TaxfreeState.Delete;
                    break;

            }
        }

        protected override void EnsureValidState()
        {
            var valid =
              Id is not null && AreaId != null &&
              (State switch
              {

                  TaxfreeState.Active => IsActive == true ,
                  TaxfreeState.DeActive => IsActive == false,
                 
                  _ => true
              });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $"Post-checks failed in state {State}"
                );
        }

        public enum TaxfreeState
        {
            Create, Chanch, Active, DeActive, Delete
        }

        #endregion Status check

    }
}
