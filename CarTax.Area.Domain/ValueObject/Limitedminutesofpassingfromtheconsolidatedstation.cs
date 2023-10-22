using CarTax.Area.Domain.ValueObjects;
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Domain.ValueObject
{
    public class Limitedminutesofpassingfromtheconsolidatedstation :ValueObject<Limitedminutesofpassingfromtheconsolidatedstation>
    {
        public int Value { get; }

        protected Limitedminutesofpassingfromtheconsolidatedstation() { }

        private Limitedminutesofpassingfromtheconsolidatedstation(int Limitedminutes)
        {
            Value = Limitedminutes;
        }

        public static Limitedminutesofpassingfromtheconsolidatedstation Create(int Limitedminutes)
        {
           

            return new Limitedminutesofpassingfromtheconsolidatedstation(Limitedminutes);
        }

        public static implicit operator Limitedminutesofpassingfromtheconsolidatedstation(int Limitedminutes)
            => new Limitedminutesofpassingfromtheconsolidatedstation(Limitedminutes);

        public static implicit operator decimal(Limitedminutesofpassingfromtheconsolidatedstation maximumdailytaxamount)
            => maximumdailytaxamount.Value;

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return new Limitedminutesofpassingfromtheconsolidatedstation(Value);
        }
    }
}
