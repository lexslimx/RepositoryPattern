using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Database;

public class Repository<T> : IRepository<T> where T : class, new()
{
    protected readonly DbContext _context;
    public Repository(DbContext context)
    {
        _context = context;
    }
    public T AddItem(T entity)
    {
        _context.Set<T>().Add(entity);
        return entity;
    }
    public T GetItem(Expression<Func<T, bool>> predicate)
     => _context.Set<T>()?.FirstOrDefault(predicate);
    public IEnumerable<T> GetItems(Expression<Func<T, bool>> predicate)
     => _context.Set<T>().Where(predicate);
    public (IEnumerable<T> items, int count) GetItems(Expression<Func<T, bool>> predicate, int? skipSize, int? count)
    => (
        _context.Set<T>().Where(predicate).Skip((int)skipSize).Take((int)count),
        _context.Set<T>().Where(predicate).ToList().Count()
      );
    public void Remove(Expression<Func<T, bool>> predicate)
    {
        T item = _context.Set<T>().FirstOrDefault(predicate);
        _context.Entry(item).State = EntityState.Deleted;
    }
}
 