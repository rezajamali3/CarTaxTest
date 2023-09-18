

using Cartax.Domain.Domain.Tax.Event;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Cartax.Domain.Common.Primitives;

 public interface IDomainEvent : INotification
 {
      
}

public interface IDomainEventAdd : IDomainEvent
{
    List<IDomainEvent> _events { get; }

    IEnumerable<IDomainEvent> GetEvents();

    void ClearEvents();

    void AddEvent(IDomainEvent @event);

    Task StartEvent(IDomainEvent data);
}


public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent
{
    Task Handle(TEvent notification, CancellationToken cancellationToken);
}

public interface IDomainEventDispatcher
{
    Task DispatchAsync<TEvent>(TEvent domainEvent) where TEvent : IDomainEvent;
}

public class DomainEventDispatcher : IDomainEventDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public DomainEventDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task DispatchAsync<TEvent>(TEvent domainEvent) where TEvent : IDomainEvent
    {
       // var handlers = _serviceProvider.GetServices<IDomainEventHandler<TEvent>>();
        //foreach (var handler in handlers)
        //{
        //    await handler.HandleAsync(domainEvent);
        //}
    }
}
