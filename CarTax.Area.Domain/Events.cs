namespace CarTax.Area.Domain
{
    public  class Events
    {

        public static class V1
        {

            #region Event Area

            public record NewArea
            {

                public int Id { get; set; }

                public int CityId { get; set; }

                public string AreaName { get; set; }

                public string AreaCode { get; set; }

                public decimal Maximumdailytaxamount { get; set; }
                public int LimitedMinutes { get; set; }
                public bool IsActive { get; set; }

                public override string ToString()
                    => $"{nameof(NewArea)}";
            }

            public record ChanchDetailsArea
            {
                public int Id { get; set; }

                public int CityId { get; set; }

                public decimal Maximumdailytaxamount { get; set; }
                public int     LimitedMinutes     { get; set; }

                public string AreaName { get; set; }

                public string AreaCode { get; set; }

                public bool IsActive { get; set; }


                public override string ToString()
                    => $"{nameof(ChanchDetailsArea)}";
            }

            public record AreaActive
            {
                public int Id { get; set; }



                public override string ToString()
                    => $"{nameof(AreaActive)}";
            }

            public record AreaDeActive
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(AreaDeActive)}";
            }

            public record AreaDelete
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(AreaDelete)}";
            }

          

            #region Specific hourly tax
            public record Newspecifiedhourstax
            {

                public TimeSpan StartDate { get;  set; }

                public TimeSpan EndDate { get;  set; }

                public decimal Tax { get;  set; }

                public int AreaId { get;  set; }

                public override string ToString()
                    => $"{nameof(Newspecifiedhourstax)}";
            }

            public record Deletespecifiedhourstax
            {


                public int specifiedhourstaxId { get;  set; }


                public int AreaId { get;  set; }


                public override string ToString()
                    => $"{nameof(Newspecifiedhourstax)}";


            }

            #endregion Specific hourly tax

            #region Taxfreecar

            public record NewTaxfreecar
            {

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
                public int AreaId { get; set; }
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(TaxfreecarDelete)}";

            }

            public record TaxfreecarActive
            {
                public int AreaId { get; set; }
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(TaxfreecarActive)}";
            }

            public record TaxfreecarDeActive
            {
                public int AreaId { get; set; }
                public int Id { get; set; }


                public override string ToString()
                    => $"{nameof(TaxfreecarDeActive)}";
            }

            #endregion Taxfreecar

            #endregion Event Area
        }

    }
}