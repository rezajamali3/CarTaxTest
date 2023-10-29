
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Message
{
    public static class Commands
    {

        public static class V1
        {

            public record NewTaxCarType
            {
                public byte? id { get; set; }
                public string carName { get; set; }
                public bool isActive { get; set; }
                public bool isTaxActive { get; set; }
                public override string ToString()  => $"{nameof(NewTaxCarType)}";
            }

            public record ChancheCarTypeName
            {
                public byte? id { get; set; }
                public string carName { get; set; }

                public override string ToString()  => $"{nameof(ChancheCarTypeName)}";
            }

            public record TaxCarTypeDelete
            {

                public byte id { get; set; }


                public override string ToString()   => $"{nameof(TaxCarTypeDelete)}";

            }


            public record TaxCarTypeActive
            {
                public byte id { get; set; }

                public override string ToString()   => $"{nameof(TaxCarTypeActive)}";
            }

            public record TaxCarTypeDeActive
            {
                public byte id { get; set; }

                public override string ToString()  => $"{nameof(TaxCarTypeDeActive)}";
            }

            public record TaxCarTypeTaxActive
            {
                public byte id { get; set; }

                public override string ToString()  => $"{nameof(TaxCarTypeTaxActive)}";
            }

            public record TaxCarTypeTaxDeActive
            {
                public byte id { get; set; }

                public override string ToString()  => $"{nameof(TaxCarTypeTaxDeActive)}";
            }



        }

    }
}
