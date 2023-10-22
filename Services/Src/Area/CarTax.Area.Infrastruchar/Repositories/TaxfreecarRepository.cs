



using CarTax.Area.Domain.Entity;

namespace CarTax.Area.Infrastruchar.Repositories
{
    public class TaxfreecarRepository : RepositoryBase<Taxfreecar>
    {

        public TaxfreecarRepository(AreasDBContext dbContext) : base(dbContext)
        {

        }

     

    }
}
