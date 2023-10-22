

namespace TaxCar.Publicholidays.Message
{
    public  class Commands
    {
        public static class V1
        {

            public record Definitionofpublicholidays
            {

                public DateTime Day { get; set; }
                public bool IsActive { get; set; }
                public int AreaId { get; set; }

                public override string ToString()
                    => $"{nameof(Definitionofpublicholidays)}";
            }

            public record ChanchDetailsofpublicholidays
            {
                public int PublicholidayId { get; set; }
                public DateTime Day { get; set; }
                public bool IsActive { get; set; }
                public int AreaId { get; set; }


                public override string ToString()
                    => $"{nameof(ChanchDetailsofpublicholidays)}";
            }

            public record publicholidaysDeActive
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(publicholidaysDeActive)}";
            }

            public record publicholidaysActive
            {
                public int Id { get; set; }

                public override string ToString()
                    => $"{nameof(publicholidaysActive)}";
            }

            public record Deleteofpublicholidays
            {
                public int PublicholidayId { get; set; }

                public override string ToString()
                    => $"{nameof(Deleteofpublicholidays)}";

            }

        }
    }
}