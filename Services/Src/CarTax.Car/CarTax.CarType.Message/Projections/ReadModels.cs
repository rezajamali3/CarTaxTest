

namespace CarTax.CarType.Message.Projections
{
    public  class ReadModels 
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
