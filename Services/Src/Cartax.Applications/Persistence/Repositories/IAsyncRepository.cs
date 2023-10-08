<<<<<<< HEAD
﻿

using Library_Domain.Model;
=======
﻿using Cartax.Domain.Base;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public interface IAsyncRepository<T> where T : Entity<T?>
    {
        Task<int> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);



        Task<T> GetAsync(Expression<Func<T, bool>> expression);

        Task<List<T>> ListAsync(Expression<Func<T, bool>> expression);
    }
}