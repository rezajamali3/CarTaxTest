

using Library_Domain.Interface;
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Library_Domain.Interface
{
    public interface IAsyncRepository<T> 
    {

        //  Task AddAsync(T entity);
            
        //  Task<T> Load(T entity);

     

        //Task<bool> UpdateAsync(T entity);

        //Task<bool> DeleteAsync(T entity);



        //Task<T> GetAsync(Expression<Func<T, bool>> expression);

        //Task<List<T>> ListAsync(Expression<Func<T, bool>> expression);

    }
}