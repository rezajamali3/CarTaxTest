using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain.ValueObjects
{
    public class CityId : ValueObject<CityId>
    {

        public int Value { get; }


        private CityId()
        {

        }

        private CityId(int id)
        {
            Value = id;
        }


        public static CityId Create(int id)
        {
           

            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }

            return new CityId(id);
        }

        public static implicit operator int(CityId cart)
        {
            return cart.Value;
        }

   

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { Create(Value) };
        }
    }
}
