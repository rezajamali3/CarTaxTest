using Library_Domain.Model;


namespace TaxCar.Publicholiday.Domain.ValueObjects
{
    public class PublicholidayId : ValueObject<PublicholidayId>
    {

        public int Value { get; }

        private PublicholidayId() { }

        private PublicholidayId(int id)
        {
            Value = id;
        }

        public static PublicholidayId Create(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Id not Zero");
            }
            return new PublicholidayId(id);
        }

        public static implicit operator int(PublicholidayId cart)
        {
            return cart.Value;
        }

   

        public override IEnumerable<object> GetAtomicValues()
        {
            return new[] { Create(Value) };
        }
    }
}
