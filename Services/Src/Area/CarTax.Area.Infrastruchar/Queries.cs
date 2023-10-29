
using System.Data.Common;

using System.Data.SqlClient;
using static CarTax.Area.Message.Projections.ReadModels;
using Library_Dapper;
using Dapper;
using CarTax.Area.Message.Projections;
using System.Data;

namespace CarTax.Area.Message
{
    public static class Queries
    {
        public static async Task<IEnumerable<V1.IsChackAreaId>> Query(this IDbConnection connection, QueryModels.ExistsAreaId query)
        => await connection.QueryAsync<V1.IsChackAreaId>(
                         " SELECT TOP 1 1 as \"Exists\" FROM Area WHERE Id = @id ",
                         new
                         {
                             id = query.AreaId
                         });


        //public static async Task<IEnumerable<V1.DetailsTaxCarArea>> Query(
        //    this DbConnection connection,
        //    QueryModels.GetPagingCarOwnwer query)
        //    => await connection.QueryAsync<V1.DetailsTaxCarArea>(
        //        "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
        //        " FROM  TaxCarArea where CarId=@OwnerId ORDER BY TaxCarAreaId OFFSET (@PageNo - 1) * @RowCountPerPage ROWS   FETCH NEXT @RowCountPerPage ROWS ONLY",
        //        new
        //        {
        //            OwnerId = query.OwnerCarId,
        //            PageNo = query.PageNo,
        //            RowCountPerPage = query.RowCountPerPage,
        //        });

        //public static Task<V1.DetailsTaxCarArea> Query(
        //    this DbConnection connection,
        //    QueryModels.GetTaxCarAreaId query)
        //    => connection.QuerySingleOrDefaultAsync<V1.DetailsTaxCarArea>(
        //        "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
        //        " FROM TaxCarArea  TaxCarAreaId = @Id ",
        //        new { Id = query.TaxCarAreaId });


        //public static async Task<IEnumerable<V1.DetailsTaxCarArea>> Query(this DbConnection connection,
        //    QueryModels.GetTaxDateCar query)
        //    => await connection.QueryAsync<V1.DetailsTaxCarArea>(
        //        "SELECT   TaxCarAreaId, CreateDate, Tax, Areaid, CarId, CombinedcameranumberId " +
        //        " FROM TaxCarArea  CarId = @CarId and CreateDate= @Date ",
        //        new
        //        {
        //            CarId = query.CarId,
        //            Date = query.Date
        //        });

        private static int Offset(int PageNo, int RowCountPerPage) => (PageNo - 1) * RowCountPerPage;
    }
}