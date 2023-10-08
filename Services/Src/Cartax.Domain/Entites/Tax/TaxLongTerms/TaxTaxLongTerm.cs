using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxLongTerms
{
    public class TaxTaxLongTerm : Entity
    {
        private bool? _isActive;
        public bool? IsActive => _isActive;

        public int? IdArea { get; private set; }
        public DateTime? DayStart { get; private set; }
        public DateTime? DayEnd { get; private set; }
    

        private TaxTaxLongTerm(int? id) : base(id)
        {
        }

        public static TaxTaxLongTerm Create(int? id ,int? idArea, DateTime? dayStart, DateTime? dayEnd)
        {
            return new TaxTaxLongTerm(id)
            {
                IdArea = idArea,
                DayStart = dayStart,
                DayEnd = dayEnd,
                _isActive = true
            };
        }

        public void Deactivate()
        {
            _isActive = false;
        }

        public void Activate()
        {
            _isActive = true;
        }
    }
}
