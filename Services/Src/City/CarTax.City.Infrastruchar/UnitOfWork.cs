using System.Threading.Tasks;
using Library_EF;

namespace CarTax.City.Infrastruchar
{
    public class UnitOfWork 
        : IUnitOfWork
    {
       

        private readonly CityDBContext _dbContext;


        public UnitOfWork(CityDBContext dbContext)
            => _dbContext = dbContext;


        public async Task<int> Commit() => await _dbContext.SaveChangesAsync();


    }
}