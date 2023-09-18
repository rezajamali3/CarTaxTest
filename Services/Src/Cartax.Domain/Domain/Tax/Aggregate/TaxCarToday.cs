
using Cartax.Domain.Common.Base;
using Cartax.Domain.Common.Primitives;
using Cartax.Domain.Entites.Tax.TaxCars;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Tax.Aggregate
{
    public class TaxCarToday : Aggregate<TaxCar>, IAggregate
    {
        public TaxCarToday(List<TaxCar> listcartext) : base(listcartext)
        { }
    }
}
