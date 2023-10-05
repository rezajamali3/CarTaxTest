

using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitMoneyDay : Entity
    {
        private bool? _isActive;

       
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

        public static TaxLimitMoneyDay Create(int id, decimal Tax, int? idArea)
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
