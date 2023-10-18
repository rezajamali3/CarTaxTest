using CarTax.City.Domain.ValueObjects;

namespace CarTax.Car.Domain.ValueObjects
{
    public class AreaName 
    {
        public string Value { get; }


        public AreaName() { }

        public AreaName(Name name)
        { 
            Value = name.Value;
        }

        public static AreaName Create(Name name)
        {
            return new AreaName(name);
        }

        public static implicit operator string(AreaName name) => name.Value;

    }

}
