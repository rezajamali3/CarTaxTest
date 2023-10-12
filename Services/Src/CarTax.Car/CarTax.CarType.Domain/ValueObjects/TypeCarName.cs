using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Domain.ValueObjects
{
    public class TypeCarName : ValueObject<TypeCarName>
    {

        public TypeCarName(){    }

        public string Value { get; }

        public TypeCarName(Name name)
        => Value = name.Value;

        public static TypeCarName Create(Name name)
        => new TypeCarName(name);

        public static implicit operator string(TypeCarName name) =>
            name.Value;

        public static implicit operator TypeCarName(string name) =>
            TypeCarName.Create(Name.Create( name));


        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
