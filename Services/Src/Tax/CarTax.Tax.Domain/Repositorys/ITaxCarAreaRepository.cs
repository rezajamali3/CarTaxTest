

using CarTax.Tax.Domain;
using CarTax.Tax.Domain.ValueObjects;
using Library_Domain.Interface;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain.Repositorys
{

    public interface ITaxCarAreaRepository : IAsyncRepository<TaxCarArea>
    {
      
        public Task<bool>    Exists(TaxCarAreaId carTypeId);
        public Task<TaxCarArea>   Load(TaxCarAreaId entity);
    

    }

}
