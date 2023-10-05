using System;
using Cartax.Domain.Common.Model;
using Cartax.Domain.Entites.Tax.TaxCars;


namespace Cartax.Domain.Domain.Citys.Entitys
{

    public class Area : Entity
    {
        public string? AreaName { get;private set; }
        public string? AreaCode { get; private set; }

        public City City { get; private set; }

        private Area(int? id):base(id)
        {
           
        }

        private Area(int id, string areaName, string areaCode, City city) : base(id)
        {
            this.AreaName = areaName;
            this.AreaCode = areaCode;
            this.City = city;
        }


        public static Area Create(int id, string areaName, string areaCode, City city)
        {
            return new Area(id, areaName, areaCode, city);
        }




       



        private List<TaxCar> _TaxCars = new();
        public IReadOnlyCollection<TaxCar> TaxCars => _TaxCars.ToList();



        private List<TaxTime> _TaxTime = new();
        public IReadOnlyCollection<TaxTime> TaxTimes => _TaxTime.ToList();

      




    }
}
