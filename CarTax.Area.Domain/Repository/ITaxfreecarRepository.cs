

using CarTax.Area.Domain.Entity;
using CarTax.Area.Domain.ValueObjects;
using Library_Domain.Interface;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Domain.Repositorys
{

    public interface ITaxfreecarRepository : IAsyncRepository<Taxfreecar>
    {
      
        public Task<bool>             Exists(TaxfreecarId carTypeId);
        public Task<Taxfreecar>       Load(TaxfreecarId entity);
    
    }

}
