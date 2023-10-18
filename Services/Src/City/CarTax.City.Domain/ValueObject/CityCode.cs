using CarTax.City.Domain.ValueObjects;
using Libraries_Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain.ValueObjects
{
    public class CityCode
    {

        public string Value { get; }


        protected CityCode() { }


        private CityCode(string cityCode)
        {
            Value = cityCode;
        }



        public static CityCode Create(string cityCode)
        {
            if(cityCode.Not_Empity())
                throw new ArgumentNullException(nameof(cityCode) +"not null");

            if (cityCode.Chack_Lenght(3))
                throw new Exception(nameof(cityCode) + "lass 3 Charter");

            return new CityCode(cityCode);
        }

        public static implicit operator string(CityCode name) => name.Value;



    }
}
