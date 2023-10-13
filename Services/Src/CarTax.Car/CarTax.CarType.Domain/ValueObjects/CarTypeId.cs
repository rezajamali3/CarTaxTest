using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Domain.ValueObjects
{
    public class CarTypeId : ValueObject<CarTypeId>
    {
        public byte? Value { get; }

        private CarTypeId() {   }

        private CarTypeId(byte? id)  => Value = id; 

        public static CarTypeId Create(byte? id)
        {

            if (id is null)
            {
                throw new ArgumentException("Id not null");
            }

            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }

            return new CarTypeId(id);
        }

        public static implicit operator byte?(CarTypeId CarTypeId)
        {
            return CarTypeId.Value;
        }

       

        public static implicit operator CarTypeId(byte Id)
        {
            return CarTypeId.Create(Id);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { CarTypeId.Create(Value) };
        }



    }
}