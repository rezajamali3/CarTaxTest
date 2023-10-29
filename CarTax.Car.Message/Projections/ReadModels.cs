



namespace CarTax.Car.Message.Projections
{
    public static class ReadModels
    {
        public static class V1
        {

            public class DetailsCar
            {

                public byte CarTypeId { get;  set; }

                public string CarName { get;  set; }

                public string Plack { get;  set; }

                public bool IsActive { get;  set; }

              
            }

            public class ListCar
            {

                List<Car> TypeCars { get; set; }

                public class Car
                {

                    public byte CarTypeId { get; set; }

                    public string CarName { get; set; }

                    public string Plack { get; set; }

                    public bool IsActive { get; set; }

                }

            }

        }
    }
}
