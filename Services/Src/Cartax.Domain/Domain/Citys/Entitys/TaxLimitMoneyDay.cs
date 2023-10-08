
<<<<<<< HEAD
using Library_Domain.Model;
=======

using Cartax.Domain.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxLimitMoneyDay : Entity<int>
    {
        private bool? _isActive;

        public decimal? Tax { get; private set; }

        public City City { get; private set; }

        public bool? IsActive => _isActive;

        private TaxLimitMoneyDay(int id) : base(id)
        {

        }

<<<<<<< HEAD
        private TaxLimitMoneyDay(int id, decimal? tax, int? idArea) : base(id)
=======
        private TaxLimitMoneyDay(int? id, decimal? tax, City city) : base(id)
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
        {
           
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
