using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Dapper
{

    public class QureyContext
    {

        private readonly string _connectionString;

        public QureyContext(string ConnectionsStrings)
        {
            _connectionString = ConnectionsStrings;
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);


    }
}
