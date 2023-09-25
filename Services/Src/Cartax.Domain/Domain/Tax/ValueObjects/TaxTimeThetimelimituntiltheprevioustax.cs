using Cartax.Domain.Common.Model;
using Cartax.Domain.Entites.Tax.TaxCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxTimes
{
    public class TaxTimeThetimelimituntiltheprevioustax : ValueObject
    {


        public TaxCar? TaxCarlast { get; private set; }
        public int TaxTimEnteraAndExit { get; private set; }
        public  DateTime? EndTime { get; private set ; }


        private TaxTimeThetimelimituntiltheprevioustax(TaxCar? taxCarlast, int taxTimEnteraAndExit, DateTime endTime)
        {
            TaxCarlast = taxCarlast;
            TaxTimEnteraAndExit = taxTimEnteraAndExit;
            EndTime = endTime;
        }

        public static TaxTimeThetimelimituntiltheprevioustax Create(TaxCar? taxCarlast, int taxTimEnteraAndExit, DateTime endTime)
        {
            return new TaxTimeThetimelimituntiltheprevioustax(taxCarlast, taxTimEnteraAndExit, endTime);
        }


        public bool Thetimelimituntiltheprevioustax()
        {
            if(TaxCarlast is null)
                return true;

            if (Timedifference()< TaxTimEnteraAndExit)
                return true;

            return false;

        }

        public int  Timedifference()
        {
            



                DateTime? startTime = TaxCarlast.CreateDate;
               

                TimeSpan duration = (TimeSpan)(EndTime - startTime);

               
               return duration.Minutes;

           
        }


        public override IEnumerable<object> GetAtomicValues()
        {
            yield return TaxCarlast;
            yield return TaxTimEnteraAndExit;
            yield return EndTime;
        }
    }
}
