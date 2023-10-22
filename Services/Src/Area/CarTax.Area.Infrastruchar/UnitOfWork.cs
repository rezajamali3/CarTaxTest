
using Library_EF;
using Microsoft.EntityFrameworkCore;


namespace CarTax.Area.Infrastruchar
{
    public class UnitOfWork
        : IUnitOfWork , IDisposable
    {

        private readonly AreasDBContext _dbContext;

        public UnitOfWork(AreasDBContext dbContext)
        => _dbContext = dbContext;
           
        public Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            return _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Commit()
        {

            using (var transaction = _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                try
                {
                    int result = await _dbContext.SaveChangesAsync();

                    if (result != 0)
                        return result;
                    transaction.Commit();
                }
                catch 
                {
                    transaction.Rollback();
                    throw;
                }
                finally {
                    Dispose();
                }
            }

            return 0;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}