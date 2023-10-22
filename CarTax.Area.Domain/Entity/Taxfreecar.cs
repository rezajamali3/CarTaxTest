
using CarTax.Area.Domain.ValueObjects;
using CarTax.Area.Message;
using Library_Domain.Model;


namespace CarTax.Area.Domain.Entity;

public class Taxfreecar : Entity<TaxfreecarId>
    {

    #region Constructor


    protected Taxfreecar()
    {

    }



    public Taxfreecar(Action<object> applier) : base(applier)
    {

    }

   

        #endregion Constructor

        #region Prpertiy

        public int TypeCarId { get; private set; }

        public bool? IsActive { get; private set; }

        public TaxfreeState State { get; private set; }

        #endregion Prpertiy

    

        #region Status check

        protected override void When(object @event)
        {
            switch (@event)
            {

                case Events.V1.NewTaxfreecar e:

                    TypeCarId = e.TypeCarId;
                    IsActive = e.IsActive;
                    State = TaxfreeState.Create;

                    break;

                case Events.V1.ChancheTaxfreecar e:

                    TypeCarId = e.TypeCarId;
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
              Id is not null  &&
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


public class TaxfreecarId : ValueObject<TaxfreecarId>
{
    public int Value { get; }

    private TaxfreecarId() { }

    private TaxfreecarId(int id) => Value = id;

    public static TaxfreecarId Create(int id)
    {



        if (id == 0)
        {
            throw new ArgumentException("Id not Zero");
        }

        return new TaxfreecarId(id);
    }

    public static implicit operator int(TaxfreecarId CarTypeId)
    {
        return CarTypeId.Value;
    }



    public static implicit operator TaxfreecarId(int Id)
    {
        return TaxfreecarId.Create(Id);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        return new[] { TaxfreecarId.Create(Value) };
    }



}
