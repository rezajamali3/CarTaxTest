namespace CarTax.Taxfreecar.Message
{
    public  class Commands
    {
        public static class V1
        {

            public record NewTaxfreecar
            {
                public int Id { get; set; }

                public int TypeCarId { get; set; }

                public int AreaId { get; set; }

                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(NewTaxfreecar)}";

            }

            public record ChancheTaxfreecar
            {
                public int Id { get; set; }
                public int TypeCarId { get; set; }

                public int AreaId { get; set; }

                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(ChancheTaxfreecar)}";
            }

            public record TaxfreecarDelete
            {

                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(TaxfreecarDelete)}";

            }

            public record TaxfreecarActive
            {

                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(TaxfreecarActive)}";
            }

            public record TaxfreecarDeActive
            {

                public int Id { get; set; }


                public override string ToString()
                    => $"{nameof(TaxfreecarDeActive)}";
            }



        }
    }
}