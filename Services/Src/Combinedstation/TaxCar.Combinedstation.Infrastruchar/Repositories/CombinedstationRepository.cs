



using TaxCar.Combinedstation.Core;
using TaxCar.Combinedstation.Infrastruchar;

namespace CarTax.Combinedstation.Infrastruchar.Repositories
{
    public class CombinedstationRepository : RepositoryBase<CombinedStations>
    {
        public CombinedstationRepository(CombinedstationDBContext dbContext) : base(dbContext) { }
    }
}
