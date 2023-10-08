using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Model
{
    public abstract class ValueObject  
    {

        protected ValueObject() { }

        public abstract IEnumerable<object> GetAtomicValues();


        public override bool Equals(object? obj)
        {
            return obj is ValueObject other && ValueAreEqual(other);
        }

        private bool ValueAreEqual(ValueObject other)
        {
            return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
        }

        public override int GetHashCode()
        {
            return GetAtomicValues().Aggregate(default(int), HashCode.Combine);
        }

        public bool Equals(ValueObject? other)
        {
            return other is not null && ValueAreEqual(other);
        }
    }
}