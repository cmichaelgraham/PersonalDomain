using System;
using System.Linq;
using Data.Seedwork;
using Domain.Seedwork.Entities;

namespace Data.EntityFramework.Repository
{
    public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity, TContext> where TEntity : Entity
                                                                                             where TContext : IContext
    {
        public virtual TContext Context { get; private set; }

        protected BaseRepository(TContext context)
        {
            Context = context;
        }

        public abstract void Add(TEntity entity);
        public abstract void Delete(TEntity entity);
        public abstract IQueryable<TResult> Select<TResult>(Func<TEntity, TResult> selector);
        public abstract void Update(TEntity entity);
    }
}
