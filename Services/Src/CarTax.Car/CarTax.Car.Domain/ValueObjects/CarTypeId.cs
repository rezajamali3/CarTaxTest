using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class CarTypeId : ValueObject
    {
        public byte Value { get; }

        private CarTypeId(byte id)
        {

            Value = id;
        }


        public static CarTypeId Create(byte id)
        {


            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }

            return new CarTypeId(id);
        }

        public static implicit operator byte(CarTypeId CarTypeId)
        {
            return CarTypeId.Value;
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { CarId.Create(Value) };
        }
    }
}