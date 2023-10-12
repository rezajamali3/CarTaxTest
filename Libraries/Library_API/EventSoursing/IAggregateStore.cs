using Library_Domain.Model;
using System;
using System.Threading.Tasks;

namespace Library_API.EventSoursing
{
    public interface IAggregateStore<T>
    {
        Task<bool> Exists(AggregateId aggregateId);

        Task Save(T aggregate) ;

        Task<T> Load(AggregateId aggregateId) ;
    }

    public interface IFunctionalAggregateStore
    {
        Task Save<T>(long version, AggregateState<T>.Result update)
            where T : class, IAggregateState<T>, new();

        Task<T> Load<T>(Guid id)
            where T : IAggregateState<T>, new();
    }
}