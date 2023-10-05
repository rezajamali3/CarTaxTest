
using Cartax.Domain.Common.Base;
using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxWeekDay : Entity
    {
        public TaxWeekDay(int? id) : base(id)
        {

        }

        public TaxWeekDay(int? id, int datyTyps, int taxDays, bool isActive, int? idArea) : base(id)
        {
            Id = id;
            DatyTyps = datyTyps;
            TaxDays = taxDays;
            IsActive = isActive;
            IdArea = idArea;
        }

        public int? IdArea { get; private set; }

        public int DatyTyps { get; private set; }

        public int TaxDays { get; private set; }

        public bool IsActive { get; private set; }

        public static TaxWeekDay Create(int? id, int datyTyps, int taxDays, bool isActive, int? idArea)
        {
            return new TaxWeekDay(id,
                  datyTyps,
                taxDays,
                 isActive,
                 idArea
            );
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public Area Area { get;  }

    }
}
