using System.Collections.Generic;
using System.Data.Common;

using Dapper;



using static TaxCar.Tax.Message.Projections.ReadModels;


namespace TaxCar.Tax.Message.Projections
{
    public static class Queries
    {
        public static async Task<IEnumerable<V1.DetailsTaxCarArea>> Query(this DbConnection connection, QueryModels.GetPageing query)
        => await connection.QueryAsync<V1.DetailsTaxCarArea>(
                         "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
                         " FROM  TaxCarArea ORDER BY TaxCarAreaId OFFSET @offset ROWS   FETCH NEXT @RowCountPerPage ROWS ONLY",
                         new
                         {
                             RowCountPerPage = query.RowCountPerPage,
                             offset = Offset(query.PageNo, query.RowCountPerPage),
                         });
        

        public static async Task<IEnumerable<V1.DetailsTaxCarArea>> Query(
            this DbConnection connection,
            QueryModels.GetPagingCarOwnwer query)
            => await connection.QueryAsync<V1.DetailsTaxCarArea>(
                "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
                " FROM  TaxCarArea where CarId=@OwnerId ORDER BY TaxCarAreaId OFFSET (@PageNo - 1) * @RowCountPerPage ROWS   FETCH NEXT @RowCountPerPage ROWS ONLY",
                new
                {
                    OwnerId = query.OwnerCarId,
                    PageNo = query.PageNo,
                    RowCountPerPage = query.RowCountPerPage,
                });

        public static Task<V1.DetailsTaxCarArea> Query(
            this DbConnection connection,
            QueryModels.GetTaxCarAreaId query)
            => connection.QuerySingleOrDefaultAsync<V1.DetailsTaxCarArea>(
                "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
                " FROM TaxCarArea  TaxCarAreaId = @Id ",
                new { Id = query.TaxCarAreaId });


        public static async Task<IEnumerable<V1.DetailsTaxCarArea>> Query(this DbConnection connection,
            QueryModels.GetTaxDateCar query)
            =>await connection.QueryAsync<V1.DetailsTaxCarArea>(
                "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
                " FROM TaxCarArea  CarId = @CarId and CreateDate= @Date ",
                new
                {
                    CarId = query.CarId,
                    Date=query.Date
                });

        private static int Offset(int PageNo, int RowCountPerPage) => (PageNo - 1) * RowCountPerPage;
    }
}