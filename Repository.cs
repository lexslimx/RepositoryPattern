using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Database;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
{
    protected readonly DbContext _context;
    public Repository(DbContext context)
    {
        _context = context;
    }
    public TEntity AddItem(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
        return _context.Set<TEntity>()?.AsEnumerable()?.LastOrDefault();
    }
    public TEntity AddItems(ICollection<TEntity> entities)
    {
        _context.Set<TEntity>().AddRange(entities);
        _context.SaveChanges();
        return _context.Set<TEntity>()?.AsEnumerable()?.LastOrDefault();
    }
    public TEntity GetItem(Expression<Func<TEntity, bool>> predicate)
     => _context.Set<TEntity>()?.FirstOrDefault(predicate);
    public IEnumerable<TEntity> GetItems(Expression<Func<TEntity, bool>> predicate)
     => _context.Set<TEntity>().Where(predicate);
    public (IEnumerable<TEntity> items, int count) GetItems(Expression<Func<TEntity, bool>> predicate, int? skipSize, int? count)
    => (
        _context.Set<TEntity>().Where(predicate).Skip((int)skipSize).Take((int)count),
        _context.Set<TEntity>().Where(predicate).ToList().Count()
      );
    public void Remove(Expression<Func<TEntity, bool>> predicate)
    {
        TEntity item = _context.Set<TEntity>().FirstOrDefault(predicate);
        _context.Entry(item).State = EntityState.Deleted;
    }


}
