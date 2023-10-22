using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public interface IDatabase
    {
        Task<ITransaction> BeginTransactionAsync();
    }
}
