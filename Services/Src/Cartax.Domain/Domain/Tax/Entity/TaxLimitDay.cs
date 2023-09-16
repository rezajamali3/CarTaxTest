using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxLimitDays
{
    public class TaxLimitDay : Entity
    {

        private bool? _isActive;

        public TimeSpan? Time { get; private set; }


        public bool? IsActive => _isActive;

        private TaxLimitDay(int? id) : base(id)
        {

        }

        public static TaxLimitDay Create(TimeSpan? time)
        {
            return new TaxLimitDay(null)
            {
                Time = time,
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
