using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain
{
    public static class Events
    {
        public static class V1
        {

            public record NewCity
            {

                public string CityName { get;  set; }

                public string CityCode { get;  set; }

                public bool IsActive { get;  set; }


                public override string ToString()
                    => $"{nameof(NewCity)}";

            }

            public record ChanchDetailsCity
            {
                public int Id { get; set; }

                public string CityName { get; set; }

                public string CityCode { get; set; }

                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(ChanchDetailsCity)}";
            }

            public record CityDelete
            {

                public int Id { get; set; }

                public override string ToString() 
                    => $"{nameof(CityDelete)}";

            }


            public record CityActive
            {
                public int Id { get; set; }


                public override string ToString()
                    => $"{nameof(CityActive)}";
            }

            public record CityDeActive
            {

                public int Id { get; set; }


                public override string ToString()
                    => $"{nameof(CityDeActive)}";
            }

         

        }
    }
}
