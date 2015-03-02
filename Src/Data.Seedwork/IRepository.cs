using System;
using System.Collections.Generic;
using Domain.Seedwork.Entities;

namespace Data.Seedwork
{
    public interface IRepository<TEntity, TContext> where TEntity : Entity
                                                    where TContext : IContext
    {
        TContext Context { get; }

        void Add(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TResult> Select<TResult>(Func<TEntity, TResult> selector);
        void Update(TEntity entity);
    }
}
