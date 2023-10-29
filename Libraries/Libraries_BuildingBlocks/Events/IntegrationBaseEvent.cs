using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_BuildingBlocks.Events
{
    public class IntegrationBaseEvent
    {

        public IntegrationBaseEvent() { 
        
        Id=Guid.NewGuid();
            CreateDate = DateTime.Now;
        }

        public IntegrationBaseEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }

        public Guid Id { get; private set; }

        public DateTime CreateDate { get; private set; }

    }
}
