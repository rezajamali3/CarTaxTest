

using Cartax.Domain.Common.Model;
using Cartax.Domain.Entites.CarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class City : Entity
    {
        private City(int? Id) : base(Id)
        {
            this.CityName = string.Empty;
            this.CityCode = string.Empty;
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

        public static City Create(int? id)
        {
            return new City(id);
        }

        public static City Create(City city)
        {
            return new City(city.Id,city.CityName,city.CityCode);
        }


        public virtual ICollection<CarType> CarTypes { get; }
        public virtual ICollection<Area> Areas { get;  }
    }
}
