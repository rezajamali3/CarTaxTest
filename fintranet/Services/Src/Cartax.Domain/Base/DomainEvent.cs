using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Base
{
    public class DomainEvent 
    {
        public Guid Id { get; protected set; }

        public int Version { get; protected set; }

        private readonly List<object> _events = new List<object>();

        public IEnumerable<object> GetEvents() => _events.AsReadOnly();

        public void ClearEvents() => _events.Clear();

        protected void AddEvent(object @event)
        {
            _events.Add(@event);
        }
    }
}
