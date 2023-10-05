using Cartax.Domain.Common.Model;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitTime : Entity
    {


        public TimeSpan? Time { get; private set; }
        public City City { get; private set; }
        public bool? IsActive { get; private set; }

        
        private TaxLimitTime(int? id) : base(id)
        {
        }

        public static TaxLimitTime Create(int? id, TimeSpan? time, City city)
        {

            return new TaxLimitTime(id)
            {
                Time = time,
                IsActive = true,
                City = city
            };

        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

      
    }
}
