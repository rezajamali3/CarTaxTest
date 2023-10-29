
using Event.Bus;
using MassTransit;

namespace CarTax.Area.Application.Consumer
{
    public class GetTestEventConsumer : IConsumer<TestEvent>
    {
      

        public Task Consume(ConsumeContext<TestEvent> context)
        {
            //throw new NotImplementedException();
            return Task.CompletedTask;
        }
    }
}