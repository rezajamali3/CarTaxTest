
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarTax.Area.Message.Projections

{
    public static class ReadModels
    {
        public static class V1
        {

            public class Area
            {

                public string  AreaName { get; set; }

                public string  AreaCode { get; set; }

                public int     Maximumdailytaxamount { get; private set; }

                public decimal limitedMinutes { get; private set; }

                public int CityId { get; private set; }

                public bool IsActive { get; private set; }

            }

            public class IsChackAreaId
            {
                public bool Exists { get; set; } = false;
            }

        }
    }
}
