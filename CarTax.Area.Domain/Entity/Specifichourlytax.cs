
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using Library_Domain.Model;
using CarTax.Area.Domain.ValueObjects;
using CarTax.Area.Domain;
using CarTax.Area.Message;

using NPOI.SS.Formula.Functions;
using static CarTax.Area.Domain.Areas;

namespace CarTax.Area.Domain.Entity;

public class Specifichourlytax : Entity<SpecifichourlytaxId>
{


    #region  Constructor
    
    protected Specifichourlytax()
    {

    }



    public Specifichourlytax(Action<object> applier) : base(applier)
    {

    }

    #endregion  Constructor


    #region Prpertiy

         

        public Specifichourly  Specifichourly { get; private set; }

        public SpecifichourlyTax Tax { get; private set; }

        public SpecifichourlytaxState State { get; private set; }

       

    #endregion Prpertiy


    #region Behavior



    public void Deletespecifiedhourstax( int areaId) =>
           Apply(new Events.V1.Deletespecifiedhourstax()
           {
             specifiedhourstaxId=  Id ,
             AreaId= areaId
           });

        #endregion Behavior


    #region State Chack


        protected override void When(object @event)
        {

            switch (@event)
            {

                case Events.V1.Newspecifiedhourstax e:
                    Specifichourly = Specifichourly.Create(e.StartDate,e.EndDate);
                   
                   
                    Tax = SpecifichourlyTax.Create( e.Tax);


                    State = SpecifichourlytaxState.Create;
                    break;

                case Events.V1.Deletespecifiedhourstax e:

                    State = SpecifichourlytaxState.Delete;
                    break;

            };

        }

    protected override void EnsureValidState()
    {
        var valid = Id is not null && _applier is not null
           && (State switch
           {

               SpecifichourlytaxState.Create =>  Specifichourly is not null && Tax is not null,
              

               _ => true
           });

        if (!valid)
            throw new DomainExceptions.InvalidEntityState(
                this, $"Post-checks failed in state {State}"
            );

    }

    public enum SpecifichourlytaxState 
        {
            Create, Chanch, Active, DeActive, Delete
        }


        #endregion State Chack


}

public class Specifichourly : ValueObject<Specifichourly>
{

    public string Value => $"{StartTimeSpan} / {EndTimeSpan}";

    public Specifichourly()
    {

    }


    private Specifichourly(TimeSpan startTimeSpan, TimeSpan endTimeSpan)
    {

        StartTimeSpan = startTimeSpan;
        EndTimeSpan = endTimeSpan;

    }


    public static Specifichourly Create(TimeSpan startTimeSpan, TimeSpan endTimeSpan)
    {


        if (startTimeSpan == null)
            throw new ArgumentException("Null");

        if (endTimeSpan == null)
            throw new ArgumentException("Null");


        if (startTimeSpan < endTimeSpan)
            throw new ArgumentException("Null");

        if (startTimeSpan > endTimeSpan)
            throw new ArgumentException("Null");

        return new Specifichourly(startTimeSpan, endTimeSpan);

    }

    public TimeSpan StartTimeSpan { get; }

    public TimeSpan EndTimeSpan { get; }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return StartTimeSpan;
        yield return EndTimeSpan;
    }

    public override string ToString()
    {
        return $"{StartTimeSpan.ToString()} {Value}";
    }

}

public class SpecifichourlyTax
{

    public decimal Value { get; }

    public SpecifichourlyTax() { }

    public SpecifichourlyTax(decimal tax)
    {
        Value = tax;
    }

    public static SpecifichourlyTax Create(decimal tax)
    {
        if (tax == default)
            throw new ArgumentNullException(nameof(tax));

        if (tax <= 0)
            throw new ArgumentOutOfRangeException(nameof(tax));

        return new SpecifichourlyTax(tax);
    }

    public static implicit operator decimal(SpecifichourlyTax tax) => tax.Value;
}

public class SpecifichourlytaxId : ValueObject<SpecifichourlytaxId>
{

    public int Value { get; }

    private SpecifichourlytaxId() { }

    private SpecifichourlytaxId(int id)
    {
        Value = id;
    }

    public static SpecifichourlytaxId Create(int id)
    {
        if (id == 0)
        {
            throw new ArgumentException("Id not Zero");
        }
        return new SpecifichourlytaxId(id);
    }

    public static implicit operator int(SpecifichourlytaxId cart)
    {
        return cart.Value;
    }



    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Create(Value);
    }
}