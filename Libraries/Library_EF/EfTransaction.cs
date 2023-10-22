using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public class EfTransaction : ITransaction
    {


        private IDbContextTransaction _dbContextTransaction;


        public EfTransaction(IDbContextTransaction dbContextTransaction)
        {
            _dbContextTransaction = dbContextTransaction;
        }


        public Task CommitAsync() => 
            _dbContextTransaction.CommitAsync();
        public Task RollbackAsync() =>
            _dbContextTransaction.RollbackAsync();


        public void Dispose()
        {
            _dbContextTransaction?.Dispose();
            _dbContextTransaction = null!;
        }


    }


}
