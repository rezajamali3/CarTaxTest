
using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxPublicholiday : Entity
    {
        public DateTime? Day { get; private set; }
        public bool? IsActive { get; private set; }
        public int? IdArea { get; private set; }

        private TaxPublicholiday(int? id) : base(id)
        {
        }

        private TaxPublicholiday(int? id, DateTime day, int? idArea) : base(id)
        {
            Id = id;
            Day = day;
            IsActive = true;
            IdArea = idArea;
        }

        public static TaxPublicholiday Create(int? id,DateTime day, int? idArea)
        {
            return new TaxPublicholiday(id, day,  idArea);
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public Area Area { get;  }

    }
}
