
using CarTax.City.Domain.ValueObjects;
using Library_Domain.Interface;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.City.Domain.Repositorys
{

    public interface ICityRepository : IAsyncRepository<Citys>
    {
      
        public Task<bool>    Exists(CityId carTypeId);
        public Task<Citys>   Load(CityId entity);
    

    }

}
