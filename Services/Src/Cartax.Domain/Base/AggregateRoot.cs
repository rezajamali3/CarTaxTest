using Cartax.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Base
{
    public abstract class AggregateRoot :IAggregateRoot
    {

        public int Id { get; protected set; }

       
    }
}
