

using Library_EF;

namespace TaxCar.Publicholidays.Infrastruchar
{
    public class UnitOfWork 
        : IUnitOfWork
    {


        private readonly PublicholidayDBContext _dbContext;


        public UnitOfWork(PublicholidayDBContext dbContext)
        => _dbContext = dbContext;


        public async Task<int> Commit() 
        => await _dbContext.SaveChangesAsync();


    }
}