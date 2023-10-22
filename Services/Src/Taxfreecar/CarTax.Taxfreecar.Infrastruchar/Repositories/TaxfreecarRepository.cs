

using CarTax.AggregateRoot;

namespace CarTax.Taxfreecar.Infrastruchar.Repositories
{
    public class TaxfreecarRepository : RepositoryBase<TaxFreeCar>
    {

        public TaxfreecarRepository(TaxfreecarDBContext dbContext) : base(dbContext)
        {

        }

     

    }
}
