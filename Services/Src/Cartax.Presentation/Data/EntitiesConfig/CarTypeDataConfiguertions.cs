
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.CarTypes;
using Cartax.Presentation.Base;


namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class CarTypeDataConfiguertions : BaseDataConfiguertions<CarType>
    {

        public CarTypeDataConfiguertions()
        {

            setData();
        }

        private void setData()
        {

            var city = City.Create(1, "تهران", "آزاد");
            CarType Normal = CarType.Create(1, city, "Normal", true, true);
            CarType Emergency = CarType.Create(2, city, "Emergency", true, true);
            CarType Busses = CarType.Create(2, city, "Busses", true, true);
            CarType Diplomat = CarType.Create(2, city, "Diplomat", true, true);
            CarType Motorcycles = CarType.Create(2, city, "Motorcycles", true, true);
            CarType Military = CarType.Create(2, city, "Military", true, true);
            CarType Foreign = CarType.Create(2, city, "Foreign", true, true);

            Data = new CarType[]
            {
                   
                //CarType.Create(1,city,"Normal",true,true),
                //  CarType.Create(2,city,"Emergency",true,false),
                //    CarType.Create(3,city,"Busses",true,false),
                //      CarType.Create(4,city,"Diplomat",true,false),
                //        CarType.Create(5,city,"Motorcycles",true,false),
                //         CarType.Create(6,city,"Military",true,false),
                //          CarType.Create(7,city,"Foreign",true,false)

            };
        }
    }
}
