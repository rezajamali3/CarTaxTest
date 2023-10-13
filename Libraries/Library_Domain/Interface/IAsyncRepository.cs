

using Library_Domain.Interface;
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Library_Domain.Interface
{
    public interface IAsyncRepository<T> where T : class
    {


         Task AddAsync(T entity);

         Task DeleteAsync(T entity);




    }
}