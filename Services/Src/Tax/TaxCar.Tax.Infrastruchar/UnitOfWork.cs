using System.Threading.Tasks;
using Library_EF;
using TaxCar.Tax.Infrastruchar;

namespace TaxCar.Tax.Infrastruchar
{
    public class UnitOfWork 
        : IUnitOfWork
    {

        private readonly TaxCarAreaDBContext _dbContext;

        public UnitOfWork(TaxCarAreaDBContext dbContext)
            => _dbContext = dbContext;

        public async Task<int> Commit() => await _dbContext.SaveChangesAsync();

    }
}