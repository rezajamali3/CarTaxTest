using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public interface IUnitOfWork2
    {
        Task BeginTransactionAsync();
        Task CommitAsync();
    }

}
