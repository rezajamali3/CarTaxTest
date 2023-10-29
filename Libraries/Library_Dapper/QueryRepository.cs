

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Dapper

{
    public class QueryRepository 
    {

        private readonly QureyContext _context;

        public QueryRepository(QureyContext context)
        => _context = context;
       

      
    }
}
