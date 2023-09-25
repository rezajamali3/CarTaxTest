
using Cartax.Domain.Common.Model;
using Cartax.Domain.Domain.Tax.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCarsTodaystaxceilingToday : ValueObject
    {

        public TaxCarToday TaxCarToday { get; private set; }
        public decimal LimaitTaxToday { get; private set; }
        public decimal TaxNow { get; private set; }


        public TaxCarsTodaystaxceilingToday(TaxCarToday taxCarToday, decimal limaitTaxToday, decimal taxNow)
        {
            TaxCarToday = taxCarToday;
            LimaitTaxToday = limaitTaxToday;
            TaxNow = taxNow;
        }

        public static TaxCarsTodaystaxceilingToday Create(TaxCarToday taxCarToday, decimal limaitTaxToday, decimal taxNow)
        {
            return new TaxCarsTodaystaxceilingToday(taxCarToday, limaitTaxToday, taxNow);
        }


        public bool? TodaystaxceilingToday()
        {

            decimal? SumTax = SumTaxTody();

            if (Taxlessthanthedailyamount(SumTax))
                return true;

            return OverFlowTax(SumTax);
        }



        private bool Taxlessthanthedailyamount(decimal? SumTax)
        {
            if ((SumTax + TaxNow) < LimaitTaxToday)
                return true;
            return false;
        }



        private bool OverFlowTax(decimal? SumTax)
        {
          
            decimal? overMoney = (SumTax + TaxNow) - LimaitTaxToday;

            return ((TaxNow - overMoney) > 0) ;
           
        }



        private decimal? SumTaxTody()
        {

            decimal? sumtax = 0;

            foreach (var item in TaxCarToday.GetAll().ToList())
            {
                sumtax += item.Tax;
            }


            return sumtax;

        }
        


     


        public override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }


    }
}
