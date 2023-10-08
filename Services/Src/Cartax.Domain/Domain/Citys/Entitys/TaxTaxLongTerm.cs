

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
    public class TaxTaxLongTerm : Entity<int?>
    {
     
        public bool? IsActive { get; private set; }
        public City? City { get; private set; }
        public DateTime? DayStart { get; private set; }
        public DateTime? DayEnd { get; private set; }
    

        private TaxTaxLongTerm(int? id) : base(id)
        {
        }

        public static TaxTaxLongTerm Create(int? id , City? city, DateTime? dayStart, DateTime? dayEnd)
        {
            return new TaxTaxLongTerm(id)
            {
                City = city,
                DayStart = dayStart,
                DayEnd = dayEnd,
                IsActive = true
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
