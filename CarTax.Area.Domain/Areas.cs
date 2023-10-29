
using CarTax.Area.Domain.Entity;
using CarTax.Area.Domain.ValueObject;
using CarTax.Area.Domain.ValueObjects;
using Library_Domain.Model;



namespace CarTax.Area.Domain
{

    public class Areas : AggregateRoot<AreaId?>
    {

        #region Constructor

        private Areas(AreaId? id) : base(id)
        {

        }

        private Areas(AreaId id, AreaName areaName, AreaCode areaCode, int idCity) : base(id)
        {

            AreaName = areaName;
            AreaCode = areaCode;
            CityId = idCity;

        }

        #endregion Constructor

        #region Prpertiy

        public AreaName AreaName { get; private set; }
        public AreaCode AreaCode { get; private set; }

        public Maximumdailytaxamount Maximumdailytaxamount { get; private set; }
        public Limitedminutesofpassingfromtheconsolidatedstation limitedMinutes { get; private set; }

        public int CityId { get; private set; }

        public bool IsActive { get; private set; }

        public AreaState State { get; private set; }

       

        private List<Specifichourlytax> _Specifichourlytaxes = new();
        public IReadOnlyList<Specifichourlytax> Specifichourlytaxes
         => _Specifichourlytaxes.ToList();


        private List<Taxfreecar> _Taxfreecar = new();
        public IReadOnlyList<Taxfreecar> Taxfreecar
         => _Taxfreecar.ToList();



        #endregion Prpertiy

        #region Behavior 

        public static Areas Create(int id, string areaName, string areaCode, decimal maximumdailytaxamount, int cityId,int limitedMinutes, bool isActive)
        {

            var area = new Areas(AreaId.Create(id));

            area.Apply(new Events.V1.NewArea
            {
                Id = id,
                Maximumdailytaxamount = maximumdailytaxamount,
                LimitedMinutes = limitedMinutes,
                AreaCode = areaCode,
                AreaName = areaName,
                CityId = cityId,
                IsActive = isActive
            }
            ); ;

            return area;
        }

        public void ChancheArea(string areaName, string areaCode, decimal maximumdailytaxamount, int cityId, int limitedMinutes, bool isActive)
        => Apply(new Events.V1.ChanchDetailsArea
        {
            CityId = cityId,
            Maximumdailytaxamount = maximumdailytaxamount,
            LimitedMinutes = limitedMinutes,
            AreaName = areaName,
            AreaCode = areaCode,
            IsActive = isActive
        });

        public void AreaActive()
        => Apply(new Events.V1.AreaActive());

        public void AreaDeActive()
        => Apply(new Events.V1.AreaActive());

        public void AreaDelete()
        => Apply(new Events.V1.AreaDelete());

        #region specifiedhourstax

        public void Newspecifiedhourstax(TimeSpan StartDate, TimeSpan EndDate, decimal Tax, int AreaId)
        => Apply(new Events.V1.Newspecifiedhourstax {
            AreaId = AreaId,
            StartDate = StartDate,
            EndDate = EndDate,
            Tax = Tax
        });

        public void Deletespecifiedhourstax(int specifiedhourstaxId)
        => Apply(new Events.V1.Deletespecifiedhourstax
        {
            AreaId = Id.Value,
            specifiedhourstaxId = specifiedhourstaxId,
        });

        #endregion  specifiedhourstax

        #region  Taxfreecar

        public void NewTaxfreecar(int areaId, int TypeCarId, bool isActive)
        => Apply(new Events.V1.NewTaxfreecar
        {
            TypeCarId = TypeCarId,
            AreaId = areaId,
            IsActive = isActive,
        }
            );

        public void ChancheTaxfreecar(int areaId, int TypeCarId, bool isActive) =>
         Apply(new Events.V1.ChancheTaxfreecar
         {
             TypeCarId = TypeCarId,

             AreaId = Id.Value,
             IsActive = isActive
         });

        public void TaxfreecarActive(int id)
        => Apply(new Events.V1.TaxfreecarActive
        {
            AreaId = Id.Value,
            Id = id
        });

        public void TaxfreecarDeActive(int id)
        => Apply(new Events.V1.TaxfreecarDeActive
        {
            AreaId = Id.Value,
            Id = id
        });

        public void TaxfreecarDelete(int id)
        => Apply(new Events.V1.TaxfreecarDelete
        {
            AreaId = Id.Value,
            Id = id
        });


        #endregion  Taxfreecar

        #region Tax

        private bool This_tax_is_not_weekendsDateTime(DateTime dateCreate)
        {


            DayOfWeek dayOfWeek = dateCreate.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }


            return false;
        }

        private bool Tax_is_not_collected_duringthe_month_of_July(DateTime dateCreate)
        {

            string month = dateCreate.ToString("MMMM");

            if (month.Equals("July"))
            {
                return false;
            }

            return false;
        }

        private bool One_time_tax_law(DateTime startDateTime, DateTime endDateTime)
        {

            TimeSpan timeDifference = endDateTime - startDateTime;
            int minutes = (int)timeDifference.TotalMinutes;

            if (60 > minutes)
                return true;

            return false;

        }

        private bool Tax_exempt_cars(int typeCarid)
        {

            foreach (var item in _Taxfreecar)
                if (item.TypeCarId == typeCarid && item.IsActive == true)
                    return true;

            return false;
        }

        

        //--------------------
        private decimal getSpecifichourlytax(TimeSpan timeSpan)
        {

            foreach (var item in _Specifichourlytaxes)
                if (item.Specifichourly.StartTimeSpan <= timeSpan &&
                   item.Specifichourly.StartTimeSpan >= timeSpan)
                    return item.Tax.Value;


            return 0;
        }

        public decimal TaxCalculation(
            DateTime TaxdateCreate ,
            DateTime TaxEndTime,
            bool isPublicholidays,
            bool isdaybeforepublicholidays,
            decimal SumTaxToday ,
            int typeCarid )
        {
            if (isPublicholidays == true)
                return 0;

            if (isdaybeforepublicholidays == true)
                return 0;

            if (This_tax_is_not_weekendsDateTime(TaxdateCreate))
                return 0;

            if (Tax_is_not_collected_duringthe_month_of_July(TaxdateCreate))
                return 0;

            if (One_time_tax_law(TaxdateCreate, TaxEndTime))
                return 0;

            if (Tax_exempt_cars(typeCarid))
                return 0;

            decimal tax = getSpecifichourlytax(TaxdateCreate.TimeOfDay);

            if (tax == 0)
                return 0;

            var maximum_daily_tax_amount = ValueObjects.Maximum_daily_tax_amount.Create(SumTaxToday, Maximumdailytaxamount.Value, tax);

            var Maximum_daily_tax_amount = maximum_daily_tax_amount.CalculatorMoney();

            if (Maximum_daily_tax_amount <= 0)
                return 0;


            return Maximum_daily_tax_amount;
        }


        #endregion Tax

        #endregion Behavior

        #region Chack State

        protected override void When(object @event)
        {
            switch (@event)
            {

                case Events.V1.NewArea e:
                    AreaCode = AreaCode.Create(e.AreaCode);
                    AreaName = AreaName.Create(Name.Create(e.AreaName));
                    CityId   = e.CityId;
                    IsActive = e.IsActive;
                    State = AreaState.Create;
                    break;

                case Events.V1.ChanchDetailsArea e:
                    AreaCode = AreaCode.Create(e.AreaCode);
                    AreaName = AreaName.Create(Name.Create(e.AreaName));
                    CityId   = e.CityId;
                    IsActive = e.IsActive;
                    State = AreaState.Chanch;
                    break;

                case Events.V1.AreaActive e:
                    IsActive = true;

                   State = AreaState.Active;
                    break;

                case Events.V1.AreaDeActive e:
                    IsActive = false;
                    State = AreaState.DeActive;
                    break;

                case Events.V1.AreaDelete e:
                    State = AreaState.Delete;
                    break;

                case Events.V1.Newspecifiedhourstax e:

                    Specifichourlytax specifichourlytax = new Specifichourlytax(Apply);
                    ApplyToEntity(specifichourlytax, e);
                    _Specifichourlytaxes.Add(specifichourlytax);
                    State = AreaState.Newspecifiedhourstax;

                    break;

                case Events.V1.Deletespecifiedhourstax e:

                  var specifichourlytaxDeletet = Findspecifiedhourstax( SpecifichourlytaxId.Create(e.specifiedhourstaxId));
                    ApplyToEntity(specifichourlytaxDeletet, e);
                    _Specifichourlytaxes.Remove(specifichourlytaxDeletet);
                    State = AreaState.Deletespecifiedhourstax;

                    break;

                case Events.V1.NewTaxfreecar e:
                    Taxfreecar taxfreecar = new Taxfreecar(Apply);
                    ApplyToEntity(taxfreecar, e);
                    _Taxfreecar.Add(taxfreecar);
                    break;

                case Events.V1.ChancheTaxfreecar e:

                    var _ChancheTaxfreecar = FindTaxfreecar(TaxfreecarId.Create(e.Id));
                    ApplyToEntity(_ChancheTaxfreecar, e);
                    //State = TaxfreeState.Chanch;
                    break;

                case Events.V1.TaxfreecarActive e:
                    var _TaxfreecarActive = FindTaxfreecar(TaxfreecarId.Create(e.Id));
                    ApplyToEntity(_TaxfreecarActive, e);
                    IsActive = true;
                    //State = TaxfreeState.Active;
                    break;

                case Events.V1.TaxfreecarDeActive e:
                    var _TaxfreecarDeActive = FindTaxfreecar(TaxfreecarId.Create(e.Id));
                    ApplyToEntity(_TaxfreecarDeActive, e);
                    //State = TaxfreeState.DeActive;
                    break;

                case Events.V1.TaxfreecarDelete e:
                    var _TaxfreecarDelete = FindTaxfreecar(TaxfreecarId.Create(e.Id));
                    ApplyToEntity(_TaxfreecarDelete, e);
                    //State = TaxfreeState.Delete;
                    break;
            };
        }


       private Specifichourlytax Findspecifiedhourstax(SpecifichourlytaxId id)
           => _Specifichourlytaxes.FirstOrDefault(x => x.Id == id);

        private Taxfreecar FindTaxfreecar(TaxfreecarId id)
          => _Taxfreecar.FirstOrDefault(x => x.Id == id);


        protected override void EnsureValidState()
        {
            var valid = Id is not null &&
                AreaName is not null &&
                AreaCode is not null &&
                CityId != 0 &&
                (State switch
                {
                   

                    AreaState.Active => IsActive == true,
                    AreaState.DeActive => IsActive == false,

                    _ => true
                });

            if (!valid)
                throw new DomainExceptions.InvalidEntityState(
                    this, $" Post-checks failed in state {State}"
                );
        }

        public enum AreaState
        {
            Create, Chanch, Active, DeActive, Delete, Newspecifiedhourstax, Deletespecifiedhourstax
        }

        #endregion Chack State

    }
}
