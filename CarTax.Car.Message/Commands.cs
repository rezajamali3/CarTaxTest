

namespace CarTax.Car.Message
{
    public static class Commands
    {
        public static class V1
        {

            public record NewCar
            {

              

                public byte CarTypeId { get; set; }

                public string CarName { get; set; }

                public string CodePlack { get; set; }

                public string NumberPlack { get; set; }

                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(NewCar)}";
            }

            public record ChanchDetailsCar
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

            public record CarActive
            {
                public int Id { get; set; }



                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }


            public record CarDeActive
            {
                public int Id { get; set; }



                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }


            public record CarDelete
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(ChanchDetailsCar)}";
            }



        }
    }
}
