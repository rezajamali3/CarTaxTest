using Library_Domain.Model;


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarTax.Area.Domain.ValueObjects
{
    public class Maximumdailytaxamount : ValueObject<Maximumdailytaxamount> 
    {

        public decimal Value { get;  }

        protected Maximumdailytaxamount() { }

        private Maximumdailytaxamount(decimal tax)
        {
            Value = tax;
        }

        public static Maximumdailytaxamount Create(decimal tax)
        {
            if (tax != 0)
                throw new ArgumentException("Tax Maximumdailytaxamount not zero");

            return new Maximumdailytaxamount(tax);
        }

        public static implicit operator Maximumdailytaxamount(decimal tax)
            => new Maximumdailytaxamount(tax);

        public static implicit operator decimal(Maximumdailytaxamount maximumdailytaxamount)
            => maximumdailytaxamount.Value;

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return new Maximumdailytaxamount(Value);
        }

    }
}
