
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Presentation.Base;


namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class TaxLimitDayDateConfigurtions : BaseDataConfiguertions<TaxLimitDay>
    {

        public TaxLimitDayDateConfigurtions()
        {

            setData();
        }

        private void setData()
        {
            var city = City.Create(1, "تهران", "آزاد");
            var area = Area.Create(1, "جنوب", "...", city);
            Data = new TaxLimitDay[]
            {

                //TaxLimitDay.Create(1,new TimeSpan(0,59,0),area),
                

            };
        }
    }
}

