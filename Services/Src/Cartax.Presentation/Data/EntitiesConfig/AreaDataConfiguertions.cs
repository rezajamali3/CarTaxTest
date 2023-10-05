
using Cartax.Presentation.Base;
using Cartax.Domain.Domain.Citys.Entitys;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class AreaDataConfiguertions : BaseDataConfiguertions<Area>
    {
       
        public AreaDataConfiguertions() {

            setData();
        }

        private void setData()
        {
            var city = City.Create(1, "تهران", "آزاد");
         
            Data = new Area[]
            {
                //Area.Create(1,"جنوب","1",city),
                //Area.Create(2,"غرب" ,"2",city),
                //Area.Create(3,"شرق" ,"3",city),
                //Area.Create(4,"شمال","4",city),
            };
        }
    }
}
