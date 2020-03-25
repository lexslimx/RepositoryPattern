
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IRepository<TEntity> where TEntity : class {
    TEntity AddItem(TEntity entity);     

    TEntity GetItem(Expression<Func<TEntity, bool>> predicate);
    IEnumerable<TEntity> GetItems(Expression<Func<TEntity, bool>> predicate);

    (IEnumerable<TEntity> items, int count) GetItems(Expression<Func<TEntity, bool>> predicate, int? skipSize, int? count);
    void Remove(Expression<Func<TEntity, bool>> predicate);

    //Add add range
    //Add remove range
}