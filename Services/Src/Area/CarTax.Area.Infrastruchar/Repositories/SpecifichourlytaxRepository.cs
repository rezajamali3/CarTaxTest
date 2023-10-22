






using CarTax.Area.Domain;
using CarTax.Area.Domain.Entity;
using CarTax.Area.Infrastruchar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Infrastruchar.Repositories
{
    public class SpecifichourlytaxRepository : RepositoryBase<Specifichourlytax>
    {
        public SpecifichourlytaxRepository(AreasDBContext dbContext) : base(dbContext)
        {
        }
    }
}
