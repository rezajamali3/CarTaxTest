using System.Threading.Tasks;
using CarTax.Car.Application;
using CarTax.Car.Infrastruchar;

namespace CarTax.CarType.Infrastruchar
{
    public class UnitOfWork 
        : IUnitOfWork
    {
       

        private readonly CarTypeDBContext _dbContext;


        public UnitOfWork(CarTypeDBContext dbContext)
            => _dbContext = dbContext;


        public async Task<int> Commit() => await _dbContext.SaveChangesAsync();


    }
}