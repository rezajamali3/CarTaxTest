using CarTax.CarType.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Application.Projections
{
    public static class ReadModels
    {
        public static class V1
        {

            public class DetailsCar
            {

                public byte id;

                public string TypeCarName { get; private set; }

                public bool? IsActive { get; private set; }

                public bool? IsTaxActive { get; private set; }
            }


            public class ListTypeCar
            {
                List<TypeCar> TypeCars { get; set; }

                public class TypeCar
                {

                  public byte   id          { get; set; }

                  public string TypeCarName { get;  set; }

                  public bool?  IsActive    { get;  set; }

                  public bool?  IsTaxActive { get;  set; }

                }
 
            }

        }
    }
}
