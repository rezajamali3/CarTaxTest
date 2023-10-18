

using CarTax.City.Domain;

namespace CarTax.City.Infrastruchar.Repositories
{
    public class CitysRepository : RepositoryBase<Citys>
    {

        public CitysRepository(CityDBContext dbContext) : base(dbContext)
        {

        }

     

    }
}
