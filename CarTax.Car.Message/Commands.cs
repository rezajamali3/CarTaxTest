using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Message
{
    public static class Commands
    {
        public static class V1
        {

            public record NewCar
            {

                public int Id { get; set; }

                public byte CarTypeId { get; set; }

                public string CarName { get; set; }

                public string CodePlack { get; set; }

                public string NumberPlack { get; set; }

                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(NewCar)}";
            }

            public class ChanchDetailsCar
            {
                public int Id { get; set; }

                public byte CarTypeId { get; set; }

                public string CarName { get; set; }

                public string CodePlack { get; set; }

                public string NumberPlack { get; set; }

                public bool IsActive { get; set; }


                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }

            public class CarActive
            {
                public int Id { get; set; }



                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }


            public class CarDeActive
            {
                public int Id { get; set; }



                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }


            public class CarDelete
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }



        }
    }
}
