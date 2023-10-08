

namespace Library_Domain.Interface;


public interface IDomainEvent 
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
      
    }
}
