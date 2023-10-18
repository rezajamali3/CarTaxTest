using System;
using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Model;

namespace CarTax.Area.Domain
{

    public class Area : Entity<AreaId?>
    {

        //public AreaName? AreaName { get; private set; }
        //public string? AreaCode { get; private set; }

        //public City City { get; private set; }

        //private Area(AreaId? id) : base(id)
        //{

        //}

        //private Area(AreaId id, AreaName areaName, string areaCode, City city) : base(id)
        //{
        //    AreaName = areaName;
        //    AreaCode = areaCode;
        //    City = city;
        //}


        //public static Area Create(AreaId id, AreaName areaName, string areaCode, City city)
        //{
        //    return new Area(id, areaName, areaCode, city);
        //}

        //protected override void When(object @event)
        //{
        //    throw new NotImplementedException();
        //}

        //protected override void EnsureValidState()
        //{
        //    throw new NotImplementedException();
        //}


        //private List<TaxCar> _TaxCars = new();
        //public IReadOnlyCollection<TaxCar> TaxCars => _TaxCars.ToList();



        //private List<TaxTime> _TaxTime = new();
        //public IReadOnlyCollection<TaxTime> TaxTimes => _TaxTime.ToList();
        protected override void EnsureValidState()
        {
            throw new NotImplementedException();
        }

        protected override void When(object @event)
        {
            throw new NotImplementedException();
        }
    }
}
