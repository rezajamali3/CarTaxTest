using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Taxfreecar.Domain.ValueObjects
{
    public class TaxfreecarId : ValueObject<TaxfreecarId>
    {
        public int Value { get; }

        private TaxfreecarId() {   }

        private TaxfreecarId(int id)  => Value = id; 

        public static TaxfreecarId Create(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }

            return new TaxfreecarId(id);
        }

        public static implicit operator int(TaxfreecarId CarTypeId)
        {
            return CarTypeId.Value;
        }

       

        public static implicit operator TaxfreecarId(int Id)
        {
            return TaxfreecarId.Create(Id);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { TaxfreecarId.Create(Value) };
        }



    }
}