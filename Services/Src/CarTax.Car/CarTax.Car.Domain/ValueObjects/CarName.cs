using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class CarName
    {
        public string Value { get; }


        public CarName() { }

        public CarName(Name name)
        {
            Value = name.Value;
        }



        public static CarName Create(Name name)
        {
            return new CarName(name);
        }

        public static implicit operator string(CarName name) => name.Value;
    }
}
