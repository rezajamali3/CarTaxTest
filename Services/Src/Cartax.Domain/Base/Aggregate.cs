using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Base
{
    public  class Aggregate<T> : IAggregate<T> where T : Entity
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

        public T GetById(int id)
        {
            return values.FirstOrDefault(t => t.Id == id);
        }


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
