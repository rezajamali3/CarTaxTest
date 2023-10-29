using Event.Events;

namespace Event.Bus
{
    public class TestEvent : IntegrationBaseEvent
    {
        public TestEvent()
        {
        }

        public TestEvent(Guid id, DateTime createDate) : base(id, createDate)
        {
        }

        public int TestP {  get; set; }
    }
}