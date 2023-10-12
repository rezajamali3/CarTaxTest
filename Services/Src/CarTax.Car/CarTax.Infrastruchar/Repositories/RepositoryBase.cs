


using System.Linq.Expressions;
using CarTax.Car.Domain;
using CarTax.Car.Domain.Repository;
using CarTax.Car.Domain.ValueObjects;
using CarTax.Car.Infrastruchar;
using Library_Domain.Interface;
using Library_Domain.Model;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;

namespace CarTax.Car.Infrastruchar.Repositories
{
    public class RepositoryBase<T> : ICarRepository
    {

        private readonly CarDBContext _dbContext;


        public RepositoryBase(CarDBContext dbContext)
        { _dbContext = dbContext; }


        public async Task AddAsync(Cars entity)
        { await _dbContext.Cars.AddAsync(entity); }


        public async Task<bool> Exists(CarId id)
        {return await _dbContext.Cars.FindAsync(id.Value) != null; }


        public async Task<Cars> Load(CarId id)
        {return await _dbContext.Cars.FindAsync(id.Value); }


        public void Dispose() { _dbContext.Dispose(); }

       

        public Task<bool> Exists(Cars id)
        {
            throw new NotImplementedException();
        }

        public Task<Cars> Load(Cars id)
        {
            throw new NotImplementedException();
        }
    }
}

