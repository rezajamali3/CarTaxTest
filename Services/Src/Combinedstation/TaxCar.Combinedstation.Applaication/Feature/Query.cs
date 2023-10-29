using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCar.Combinedstation.Applaication.Feature
{
    public class Query
    {
        public static class V1
        {
            public class CombinedStation
            {

                public Guid Id { get; set; }

                public int AreaId { get; set; }

                public int Name { get; set; }

                public int Code { get; set; }

                public bool IsActive { get; set; }

            }
        }
    }
}
