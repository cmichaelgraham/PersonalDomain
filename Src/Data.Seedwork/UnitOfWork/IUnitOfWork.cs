using System;
using Data.Seedwork.Context;

namespace Data.Seedwork.UnitOfWork
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {
        TContext Context { get; }

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
