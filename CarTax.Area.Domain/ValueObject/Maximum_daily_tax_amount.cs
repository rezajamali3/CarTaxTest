


using Library_Domain.Model;


namespace CarTax.Area.Domain.ValueObjects

{
    public class Maximum_daily_tax_amount : ValueObject<Maximum_daily_tax_amount>
    {



        public decimal TaxCarToday { get; private set; }
        public decimal LimaitTaxToday { get; private set; }
        public decimal TaxNow { get; private set; }


        public Maximum_daily_tax_amount(decimal taxCarToday, decimal limaitTaxToday, decimal taxNow)
        {
            TaxCarToday = taxCarToday;
            LimaitTaxToday = limaitTaxToday;
            TaxNow = taxNow;
        }

        public static Maximum_daily_tax_amount Create(decimal taxCarToday, decimal limaitTaxToday, decimal taxNow)
        {
            return new Maximum_daily_tax_amount(taxCarToday, limaitTaxToday, taxNow);
        }


        public decimal CalculatorMoney()
        {

            if (LimaitTaxToday == 0)
                return TaxNow;

            return Calculator(TaxCarToday);

        }

        private decimal Calculator(decimal SumTax)
        {
            if ((SumTax + TaxNow) <= LimaitTaxToday)
                return (TaxNow);


            decimal overMoney = (SumTax + TaxNow) - LimaitTaxToday;

            return (TaxNow - overMoney);
        }

        private bool OverFlowTax(decimal? SumTax)
        {
            decimal OverFlow = (decimal)(LimaitTaxToday - SumTax);

            return OverFlow >= 0;
        }

       

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return new object[] { };
        }


    }
}