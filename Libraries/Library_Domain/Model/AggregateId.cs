using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Model
{
    public abstract class AggregateId
    {
        protected AggregateId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(
                    nameof(value) , "The Id cannot be empty");

            Value = value;
        }

        public Guid Value { get; }

        public static implicit operator Guid(AggregateId self) => self.Value;

        public override string ToString() => Value.ToString();
    }
}
