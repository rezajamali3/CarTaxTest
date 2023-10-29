using System.Runtime.Intrinsics;

namespace TaxCar.Tax.Message
{
    public  class Commands
    {
        public static class V1
        {

          public record newTax
          {
            public DateTime CreateDate { get; set; }

            public decimal Tax { get; set; }

            public int Areaid { get; set; }

            public Guid CarId { get; set; }

            public int CombinedcameranumberId { get; set; }
            public override string ToString()
                => $"{nameof(newTax)}";
           }

          public record DeleteTax
        {
            public Guid TaxCarId { get; set; }

            public override string ToString()
                => $"{nameof(DeleteTax)}";

        }

      }
    }
}