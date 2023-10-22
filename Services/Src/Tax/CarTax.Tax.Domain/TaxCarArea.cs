


using CarTax.Tax.Domain.ValueObjects;
using Library_Domain.Model;
using TaxCar.Tax.Domain;

namespace CarTax.Tax.Domain
{
    public class TaxCarArea : AggregateRoot<TaxCarAreaId>
    {

        #region Constructor

        private TaxCarArea(TaxCarAreaId id) : base(id)
        {

        }

        private TaxCarArea(TaxCarAreaId id, DateTime createDate, int areaId, Guid carId, AreaTax tax, int combinedcameranumberId) : base(id)
        {
            CreateDate = createDate;
            CarId = carId;
            Areaid = areaId;
            Tax = tax;
            CombinedcameranumberId = combinedcameranumberId;
        }

        #endregion Constructor

        #region Property

        public DateTime? CreateDate       { get; private set; }

        public AreaTax Tax                    { get; private set; }

        public int Areaid                 { get; private set; }

        public Guid CarId                 { get; private set; }

        public int CombinedcameranumberId { get; private set; }

        public TaxCarState State          { get; private set; }

        


        #endregion  Property




        #region Behavior



        public static TaxCarArea Create(DateTime createDate, int areaId, Guid carId, decimal tax, int combinedcameranumberId)
        {

            var taxCar = new TaxCarArea(TaxCarAreaId.Create(Guid.NewGuid()))
            {
                CarId = carId,
                Areaid = areaId,
                Tax =AreaTax.Create(tax),
                CreateDate = createDate,
                CombinedcameranumberId = combinedcameranumberId
            };

            return taxCar;
        }


        public void DeleteTax()
            => Apply(new Events.V1.DeleteTax());


        #endregion Behavior


        #region Chack State

        protected override void When(object @event)
        {
            switch (@event)
            {
                case Events.V1.newTax e:

                    CarId = e.CarId;

                    Areaid = e.Areaid;

                    Tax = AreaTax.Create( e.Tax);

                    CreateDate = e.CreateDate;

                    CombinedcameranumberId = e.CombinedcameranumberId;

                    State = TaxCarState.Create;

                    break;
                case Events.V1.DeleteTax e:



                    State = TaxCarState.Delete;
                    break;
            }
        }
        protected override void EnsureValidState()
        {
            var valid = Id is not null;
                 

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $"Post-checks failed in state {State}"
                );
        }
        public enum TaxCarState
        {
            Create, Delete
        }
        #endregion Chack State
    }
}
