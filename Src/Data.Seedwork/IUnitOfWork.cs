using System;

namespace Data.Seedwork
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {
        TContext Context { get; }

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
