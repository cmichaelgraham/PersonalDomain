using System;
using System.Collections.Generic;
using Data.Seedwork.Context;
using Domain.Seedwork.Entities;

namespace Data.Seedwork.Repository
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
