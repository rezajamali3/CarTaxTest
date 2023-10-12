using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class CarId : ValueObject<CarId>
    {
        public int Value { get; }

        private CarId()
        {

        }

        private CarId(int id)
        {
            Value = id;
        }


        public static CarId Create(int id)
        {
           

            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }

            return new CarId(id);
        }

        public static implicit operator int(CarId cart)
        {
            return cart.Value;
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { Create(Value) };
        }
    }
}
