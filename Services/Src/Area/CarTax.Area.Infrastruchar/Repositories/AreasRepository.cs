





using CarTax.Area.Domain;
using CarTax.Area.Infrastruchar;


namespace CarTax.Area.Infrastruchar.Repositories
{
    public class AreasRepository : RepositoryBase<Areas>
    {

        public AreasRepository(AreasDBContext dbContext) : base(dbContext) { }

    }
}
