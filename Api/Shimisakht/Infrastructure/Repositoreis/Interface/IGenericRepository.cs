using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositoreis.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        abstract Task<IEnumerable<T>> ListAsync();
        abstract Task<T> GetById(Guid id);
        abstract Task<EntityEntry<T>> AddAsync(T entity);
        abstract Task<EntityEntry<T>> Delete(Guid id);
        abstract Task<EntityEntry<T>> Update(T entity);
        abstract Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
