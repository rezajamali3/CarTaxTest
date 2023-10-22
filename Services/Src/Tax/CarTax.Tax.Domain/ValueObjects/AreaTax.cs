

using Library_Domain.Model;

namespace CarTax.Tax.Domain.ValueObjects
{
    public class AreaTax : ValueObject<AreaTax>
    {
        public decimal Value { get; }

        public AreaTax() { }

        public AreaTax(decimal tax)
        {
            Value = tax;
        }

        public static AreaTax Create(decimal tax)
        {
            if (tax == default)
                throw new ArgumentNullException(nameof(tax));

            if (tax <= 0)
                throw new ArgumentOutOfRangeException(nameof(tax));

            return new AreaTax(tax);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }

        public static implicit operator decimal(AreaTax tax) => tax.Value;
    }
}
