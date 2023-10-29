using Libraries_BuildingBlocks.Events;

namespace Libraries_BuildingBlocks
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