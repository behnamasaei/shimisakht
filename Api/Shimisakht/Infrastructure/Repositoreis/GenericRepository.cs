using Domain;
using Infrastructure.Data;
using Infrastructure.Repositoreis.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositoreis;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected ApplicationContext context;
    internal DbSet<T> dbSet;
    protected readonly ILogger _logger;

    public GenericRepository(ApplicationContext context, ILogger logger)
    {
        this.context = context;
        this.dbSet = context.Set<T>();
        this._logger = logger;
    }

    public async Task<IEnumerable<T>> ListAsync()
        => await dbSet.ToListAsync();

    public async Task<T> GetById(Guid id)
        => await dbSet.FindAsync(id);

    public async Task<EntityEntry<T>> AddAsync(T entity)
        => await dbSet.AddAsync(entity);

    public async Task<EntityEntry<T>> Delete(Guid id)
    {
        var entity = await GetById(id);
        return dbSet.Remove(entity);
    }


    public async Task<EntityEntry<T>> Update(T entity)
        => dbSet.Update(entity);


    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
     => await context.Set<T>().FirstOrDefaultAsync(predicate);
}

