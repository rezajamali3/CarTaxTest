using Library_Domain.Model;
using System;
using System.Threading.Tasks;

namespace Library_API.EventSoursing
{
    public static class ApplicationServiceExtensions
    {

        //public static async Task HandleUpdate<T>(
        //    this IApplicationService service,
        //    IAggregateStore<T> store,
        //    AggregateId aggregateId,
        //    Action<T> operation)
        //    where T : AggregateRoot<T>
        //{
        //    var aggregate = await store.Load(aggregateId);

        //    if (aggregate == null)
        //        throw new InvalidOperationException($"Entity with id {aggregateId} cannot be found");

        //    operation(aggregate);
        //    await store.Save(aggregate);
        //}

    }
}