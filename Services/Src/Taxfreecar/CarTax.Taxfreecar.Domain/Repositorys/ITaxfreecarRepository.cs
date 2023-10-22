
using CarTax.AggregateRoot;
using CarTax.Taxfreecar.Domain.ValueObjects;
using Library_Domain.Interface;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Taxfreecar.Domain.Repositorys
{

    public interface ITaxfreecarRepository : IAsyncRepository<TaxFreeCar>
    {
      
        public Task<bool> Exists(TaxfreecarId carTypeId);
        public Task<TaxFreeCar>       Load(TaxfreecarId entity);
    
    }

}
