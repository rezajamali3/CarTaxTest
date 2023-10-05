

using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitTime : Entity
    {


        public TimeSpan? Time { get; private set; }

        public int? IdArea { get; private set; }
        public bool? IsActive { get; private set; }




        private TaxLimitTime(int? id) : base(id)
        {
        }

        public static TaxLimitTime Create(int? id, TimeSpan? time, int? idArea)
        {
            return new TaxLimitTime(null)
            {
                Id = id,
                Time = time,
                IsActive = true,
                IdArea = idArea
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

        public Area Area { get; }
    }
}
