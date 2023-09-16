using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxLimitTimes
{
    public class TaxLimitTime : Entity
    {

        private bool? _isActive;
        public TimeSpan? Time { get; private set; }
        public bool? IsActive => _isActive;

        private TaxLimitTime(int? id) : base(id)
        {
        }

        public static TaxLimitTime Create(int? id,TimeSpan? time)
        {
            return new TaxLimitTime(null)
            {
                Id = id,
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
