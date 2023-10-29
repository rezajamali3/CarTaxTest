
using TaxCar.Publicholidays.Infrastruchar;

namespace TaxCar.Publicholidays.Infrastruchar.Repositories
{

    public class PublicholidayRepository : RepositoryBase<Publicholiday>
    {
        public PublicholidayRepository(PublicholidayDBContext dbContext) : base(dbContext){ }
    }

}
