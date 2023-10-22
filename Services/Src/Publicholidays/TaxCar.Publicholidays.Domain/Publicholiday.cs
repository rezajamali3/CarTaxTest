




using Library_Domain.Model;
using TaxCar.Publicholiday.Domain.ValueObjects;
using TaxCar.Publicholidays.Domain;

namespace TaxCar.Publicholidays
{
    public class Publicholiday : AggregateRoot<PublicholidayId>
    {


        #region Constructor

        protected Publicholiday()
        {

        }

        private Publicholiday(PublicholidayId id) : base(id)
        {

        }


        private Publicholiday(PublicholidayId id, DateTime day, int areaId) : base(id)
        {
          
            Day = day;
            IsActive = true;
            AreaId = areaId;
        }

        #endregion Constructor


        #region Prpertiy

        public DateTime Day { get; private set; }
        public bool IsActive { get; private set; }
        public int AreaId { get; private set; }
        public PublicholidaysState State { get; private set; }

        #endregion Prpertiy


        #region Behavior 

        public static Publicholiday Create(DateTime day, int areaId,bool isActive)
        {

            var publicHoliday = new Publicholiday();

            publicHoliday.Apply(new Events.V1.Definitionofpublicholidays{
              IsActive =   isActive,
              Day      =   day, 
              AreaId   =   areaId
            });

            return publicHoliday;
        }


        public  void ChanchDetailsofpublicholidays(DateTime day, int areaId, bool isActive)
        =>  Apply(new Events.V1.ChanchDetailsofpublicholidays
            {
               
                IsActive = isActive,
                Day = day,
                AreaId = areaId
            });

  

        public void PublicholidaysActive()
        => Apply(new Events.V1.publicholidaysActive
        {
         Id = Id.Value
        });

        public void PublicholidaysDeActive()
      => Apply(new Events.V1.publicholidaysDeActive
      {
          Id=Id.Value
      });

        public void Deleteofpublicholidays()
        => Apply(new Events.V1.Deleteofpublicholidays
        {
         PublicholidayId = Id.Value
        });
        #endregion Behavior 


        #region Chack State

        protected override void When(object @event)
        {
            switch(@event)
            {
                case Events.V1.Definitionofpublicholidays e:

                  
                    Day      = e.Day;
                    IsActive = e.IsActive;
                    AreaId   = e.AreaId;
                    State = PublicholidaysState.Create;
                    break;

                case Events.V1.ChanchDetailsofpublicholidays e:

                    Day = e.Day;
                    IsActive = e.IsActive;
                    AreaId = e.AreaId;
                    State = PublicholidaysState.Chanch;
                    break;

                case Events.V1.publicholidaysActive e:

                    IsActive = true;
                    State = PublicholidaysState.Active;
                    break;

                case Events.V1.publicholidaysDeActive e:

                    IsActive = false;
                    State = PublicholidaysState.DeActive;
                    break;


                case Events.V1.Deleteofpublicholidays e:

                  
                    State = PublicholidaysState.Delete;
                    break;



            }
        }

        protected override void EnsureValidState()
        {
            var valid = 
              

                (State switch
                {

                   
                    PublicholidaysState.Chanch => Id is not null,
                    PublicholidaysState.Active => IsActive == true,
                    PublicholidaysState.DeActive => IsActive == false,

                    _ => true
                });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $" Post-checks failed in state {State}"
                );
        }

        public enum PublicholidaysState
        {
            Create, Chanch, Active, DeActive, Delete
        }
        #endregion Chack State


    }
}
