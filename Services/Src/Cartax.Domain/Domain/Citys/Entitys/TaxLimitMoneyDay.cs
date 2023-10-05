

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

        public City City { get; private set; }

        public bool? IsActive => _isActive;

        private TaxLimitMoneyDay(int? id) : base(id)
        {

        }

        private TaxLimitMoneyDay(int? id, decimal? tax, City city) : base(id)
        {
            Id = id;
            Tax = tax;

            City =city ;

        }

        public static TaxLimitMoneyDay Create(int id, decimal Tax, City city)
        {

            return new TaxLimitMoneyDay(id, Tax, city);

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
