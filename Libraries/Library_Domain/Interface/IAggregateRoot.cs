using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Interface
{
    public interface IAggregateRoot<TId> : IAggregate
    {
        public TId Id { get; protected set; }
    }
}
