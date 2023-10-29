using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;



namespace CarTax.City.Message.Projections
{
    public static class Queries
    {
        
        private static int Offset(int page, int pageSize) => page * pageSize;
    }
}