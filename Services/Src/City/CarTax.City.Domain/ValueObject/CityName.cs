using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain.ValueObjects
{
    public class CityName 
    {
        public string Value { get; }


        public CityName() { }


        public CityName(Name name)
        {
            Value = name.Value;
        }



        public static CityName Create(Name name)
        {
            return new CityName(name);
        }

        public static implicit operator string(CityName name) => name.Value;


    }
}
