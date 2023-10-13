using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Interface;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.Repository
{
    public interface ICarRepository : IAsyncRepository<Cars>
    {

        Task<bool> Exists(CarId id);
        Task<Cars> Load(CarId entity);
       

    }
}
