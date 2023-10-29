
using System.Data.Common;
using Library_Dapper;
using Dapper;



namespace CarTax.Car.Infrastruchar
{
    public static class Queries
    {

        private static int Offset(int PageNo, int RowCountPerPage) => (PageNo - 1) * RowCountPerPage;
    }
}