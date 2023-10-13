using CarTax.Car.Domain.ValueObjects;
using CarTax.CarType.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarTax.Car.Domain.Cars;

namespace CarTax.CarType.Application.Projections
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
