


using Cartax.Domain.Entites.CarTypes;
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class City : Entity<int?>
    {
        private City(int? Id) : base(Id)
        {
          
        }

        private City(int? Id, string cityName, string cityCode) : base(Id)
        {
            this.CityName = cityName;
            this.CityCode = cityCode;
        }


        public string? CityName { get; private set; }

        public string? CityCode { get; private set; }


        public static City Create(int? id,string cityName, string cityCode)
        {




            return new City(id, cityName, cityCode);
        }

     


        private List<Area> areas = new();
        public IReadOnlyCollection<Area> Areas => areas.ToList();


      

        public TaxLimitMoneyDay TaxMoneyDay { get; private set; }

        public TaxLimitTime TaxLimitTime { get; private set; }



        private List<TaxPublicholiday> _TaxPublicholidays = new();
        public IReadOnlyCollection<TaxPublicholiday> TaxPublicholiday => _TaxPublicholidays.ToList();


        private List<TaxTaxLongTerm> _TaxTaxLongTerm = new();
        public IReadOnlyCollection<TaxTaxLongTerm> TaxTaxLongTerm => _TaxTaxLongTerm.ToList();


        private List<TaxWeekDay> _TaxWeekDay = new();
        public IReadOnlyCollection<TaxWeekDay> TaxWeekDay => _TaxWeekDay.ToList();



        //public virtual ICollection<Area> Areas { get;  }

    }
}
