


using CarTax.Tax.Domain;
using TaxCar.Tax.Infrastruchar;

namespace CarTax.Tax.Infrastruchar.Repositories
{
    public class TaxCarAreaRepository : RepositoryBase<TaxCarArea>
    {

        public TaxCarAreaRepository(TaxCarAreaDBContext dbContext) : base(dbContext)
        {

        }

     

    }
}
