using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Domain.ValueObjects
{
    public class AreaId : ValueObject<AreaId>
    {

        public int Value { get; }

        private AreaId() { }

        private AreaId(int id)
        {
            Value = id;
        }

        public static AreaId Create(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }
            return new AreaId(id);
        }

        public static implicit operator int(AreaId cart)
        {
            return cart.Value;
        }

   

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { Create(Value) };
        }
    }
}
