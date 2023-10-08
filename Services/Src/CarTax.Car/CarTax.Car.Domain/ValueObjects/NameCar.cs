using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class NameCar
    {
        public string Value { get; }

        public NameCar(Name name)
        {
            Value = name.Value;
        }



        public static NameTypeCar Create(Name name)
        {
            return new NameTypeCar(name);
        }

        public static implicit operator string(NameCar name) => name.Value;
    }
}
