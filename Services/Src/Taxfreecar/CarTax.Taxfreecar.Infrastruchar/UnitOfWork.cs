using System.Threading.Tasks;

using CarTax.Taxfreecar.Infrastruchar;
using Library_EF;

namespace CarTax.Taxfreecar.Infrastruchar
{
    public class UnitOfWork 
        : IUnitOfWork
    {
       

        private readonly TaxfreecarDBContext _dbContext;


        public UnitOfWork(TaxfreecarDBContext dbContext)
            => _dbContext = dbContext;


        public async Task<int> Commit() => await _dbContext.SaveChangesAsync();


    }
}