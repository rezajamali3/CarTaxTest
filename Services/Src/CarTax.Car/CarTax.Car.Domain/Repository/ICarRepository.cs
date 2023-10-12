using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.Repository
{
    public interface ICarRepository : IAsyncRepository<Cars> {}
}
