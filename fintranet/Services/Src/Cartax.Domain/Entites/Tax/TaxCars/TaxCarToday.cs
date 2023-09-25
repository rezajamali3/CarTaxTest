using Cartax.Domain.Base;
using Cartax.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCarToday : Aggregate<TaxCar> , IAggregate
    {
        public TaxCarToday(List<TaxCar> listcartext):base(listcartext)
        { }
    }
}
