using Cartax.Domain.Common.Primitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Common.Intercpter
{
    public class PublishDomainEventIntercpter : SaveChangesInterceptor, IDomainEventAdd
    {

        private readonly IMediator _mediator;

        public PublishDomainEventIntercpter(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;

        }

        public List<IDomainEvent> _events { get ; set ; }=new List<IDomainEvent>();

        public void AddEvent(IDomainEvent @event)
        {
           
                _events.Add(@event);
            
        }

        public void ClearEvents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDomainEvent> GetEvents()
        {
            throw new NotImplementedException();
        }

        public  async Task StartEvent(IDomainEvent data)
        {

            await _mediator.Publish(data);
        }


    }
}
