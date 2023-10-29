using System;

namespace TaxCar.Tax.Message.Projections
{
    public static class QueryModels
    {
        public class GetPageing
        {
            public int PageNo { get; set; }
            public int RowCountPerPage { get; set; }
        }

        public class GetPagingCarOwnwer
        {
            public Guid OwnerCarId { get; set; }
            public int PageNo { get; set; }
            public int RowCountPerPage { get; set; }
        }

        public class GetTaxCarAreaId
        {
            public Guid TaxCarAreaId { get; set; }
        }

        public class GetTaxDateCar
        {
            public DateOnly Date { get; set; }
            public Guid CarId { get; set; }
        }
    }
}