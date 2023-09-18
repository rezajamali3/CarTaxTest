using Cartax.Domain.Common.Base;
using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Tax.TaxLimitDays;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxLimitMoneyDays
{
    public  class TaxLimitMoneyDay : Entity
    {
        private bool? _isActive;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tax { get; private set; }

        public int? IdArea { get; private set; }

        public bool? IsActive => _isActive;

        private TaxLimitMoneyDay(int? id) : base(id)
        {
           
        }

        private TaxLimitMoneyDay(int? id, decimal? tax, int? idArea) : base(id)
        {
            Id = id;
            Tax = tax;
           
            IdArea = idArea;

        }

        public static TaxLimitMoneyDay Create(int id ,decimal Tax, int? idArea)
        {
           
            return new TaxLimitMoneyDay(id, Tax, idArea);
            
        }

        public void Deactivate()
        {
            _isActive = false;
        }

        public void Activate()
        {
            _isActive = true;
        }


        public Area Area { get; }
    }
}
