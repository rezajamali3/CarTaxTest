using System;

using Cartax.Domain.Entites.Tax.TaxCars;
using Library_Domain.Model;

namespace Cartax.Domain.Domain.Citys.Entitys
{

    public class Area : Entity<int?>
    {
        public string? AreaName { get; set; }
        public string? AreaCode { get; set; }

        public int? idCity;

        private Area(int? id):base(id)
        {
           
        }

        private Area(int id, string areaName, string areaCode, int? idcity) : base(id)
        {
            this.AreaName = areaName;
            this.AreaCode = areaCode;
            this.idCity = idCity;
        }


        public static Area Create(int id, string areaName, string areaCode, int? idcity)
        {
           
            return new Area(id, areaName, areaCode, idcity);
        }


        public static Area Create(int id)
        {
            return new Area(id, String.Empty, String.Empty,null);
        }



        public City City { get;  }

        public TaxLimitDay TaxLimitDay { get;  }

        public ICollection<TaxCar> TaxCars { get; }

    

        public TaxLimitMoneyDay TaxMoneyDay { get; }

        public TaxLimitTime TaxLimitTime { get; }

        public TaxPublicholiday TaxPublicholiday { get; }

        public TaxTaxLongTerm TaxTaxLongTerm { get; }

        public TaxTime TaxTime { get; }

        public ICollection<TaxWeekDay> TaxWeekDay { get; }


    }
}
