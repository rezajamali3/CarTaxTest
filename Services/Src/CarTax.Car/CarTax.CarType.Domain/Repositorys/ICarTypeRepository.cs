
using CarTax.CarType.Domain.ValueObjects;
using Library_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.CarType.Domain.Repositorys
{

    public interface ICarTypeRepository : IAsyncRepository<CarTypes>{

        public Task<bool> Exists(CarTypeId carTypeId);
     

    }

}
