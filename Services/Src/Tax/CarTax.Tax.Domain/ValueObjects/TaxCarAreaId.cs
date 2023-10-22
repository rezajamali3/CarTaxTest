using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Tax.Domain.ValueObjects
{
    public class TaxCarAreaId : ValueObject<TaxCarAreaId>
    {

        public Guid Value { get; }


        private TaxCarAreaId()
        {

        }

        private TaxCarAreaId(Guid id)
        {
            Value = id;
        }


        public static TaxCarAreaId Create(Guid id)
        {

            return new TaxCarAreaId(id);
        }

        public static implicit operator Guid(TaxCarAreaId taxCarId)
        {
            return taxCarId.Value;
        }

   

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { Create(Value) };
        }
    }
}
