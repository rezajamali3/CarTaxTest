using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class NameTypeCar
    {

        public string Value { get; }

        public NameTypeCar(Name name)
        {
            Value = name.Value;
        }



        public static NameTypeCar Create(Name name)
        {
            return new NameTypeCar(name);
        }

        public static implicit operator string(NameTypeCar name) => name.Value;
    }
}
