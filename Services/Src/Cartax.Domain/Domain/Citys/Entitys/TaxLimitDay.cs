
using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitDay : Entity
    {

       

        public TimeSpan? Time { get; private set; }

        public int? IdArea { get; private set; }
        public bool? IsActive { get; private set; }

        private TaxLimitDay(int? id) : base(id)
        {

        }

        public static TaxLimitDay Create(int? id,  TimeSpan? time,int? idArea)
        {
            return new TaxLimitDay(id)
            {
                Time = time,
                IsActive = true ,
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
