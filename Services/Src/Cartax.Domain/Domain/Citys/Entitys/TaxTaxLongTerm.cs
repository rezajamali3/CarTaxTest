

using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxTaxLongTerm : Entity
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
