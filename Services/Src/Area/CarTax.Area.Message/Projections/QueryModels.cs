using System;

namespace CarTax.Area.Message.Projections

{
    public static class QueryModels
    {

        public class GetPageing
        {
            public int PageNo { get; set; }
            public int RowCountPerPage { get; set; }
        }

        public class GetCarOwnwer
        {
            public int OwnerCarId { get; set; }
            public int PageNo { get; set; }
            public int RowCountPerPage { get; set; }
        }

        public class GetAreaId
        {
            public int AreaId { get; set; }
        }

        public class ExistsAreaId
        {
            public int AreaId { get; set; }
        }



        public class GetCar
        {
            public DateOnly Date { get; set; }
            public Guid CarId { get; set; }
        }
    }
}