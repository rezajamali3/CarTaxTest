using Cartax.Domain.Common.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Common.Model
{
    public abstract class AggregateRoot : IAggregateRoot
    {

        public int Id { get; protected set; }


    }
}
