

using Library_Domain.Interface;

namespace Library_Domain.Model
{
    public class Aggregate<T> : IAggregate<T> where T : ValueObject<T>
    {
        private List<T>? values;

        protected Aggregate()
        {

        }

        public Aggregate(List<T>? tax)
        {
            values = tax;
        }

        public static Aggregate<T> Create(List<T> tax)
        {
            var va = new Aggregate<T>(tax);
            return va;
        }

        public void Add(T taxCar)
        {
            values.Add(taxCar);
        }

        public void Remove(T taxCar)
        {
            values.Remove(taxCar);
        }

        public List<T>? GetAll()
        {
            return values;
        }

        //public T GetById(int id)
        //{
        //    return values.FirstOrDefault(t => t.Id.GetHashCode() == id);
        //}


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
