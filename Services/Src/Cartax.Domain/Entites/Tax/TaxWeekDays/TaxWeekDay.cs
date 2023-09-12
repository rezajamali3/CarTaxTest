using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxWeekDays
{
    public class TaxWeekDay : Entity
    {
        public TaxWeekDay(int? id) : base(id)
        {

        }

        public int IdArea { get; private set; }

        public int DatyTyps { get; private set; }

        public int TaxDays { get; private set; }

        public bool IsActive { get; private set; }

        public static TaxWeekDay Create(int? id, int datyTyps, int taxDays, bool isActive, int idArea)
        {
            return new TaxWeekDay(id)
            {
                DatyTyps = datyTyps,
                TaxDays = taxDays,
                IsActive = isActive,
                IdArea= idArea
            };
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
