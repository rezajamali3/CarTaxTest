

<<<<<<< HEAD
using Library_Domain.Model;

=======
using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitDay : Entity<int?>
    {

        public TimeSpan? Time { get; private set; }

        public City City { get; private set; }

        public bool? IsActive { get; private set; }

        private TaxLimitDay(int? id) : base(id)
        {

        }

        public static TaxLimitDay Create(int? id,  TimeSpan? time, City? city)
        {
            return new TaxLimitDay(id)
            {
                Time = time,
                IsActive = true ,
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
