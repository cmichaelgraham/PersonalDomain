using Data.Seedwork.Context;
using Data.Seedwork.UnitOfWork;

namespace Data.EntityFramework.UnitOfWork
{
    public abstract class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : IContext
    {
        public TContext Context { get; private set; }

        protected UnitOfWork(TContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void BeginTransaction()
        {
            Context.ExecuteCommand("BEGIN TRANSACTION");
        }

        public void Commit()
        {
            Context.ExecuteCommand("COMMIT");
        }

        public void Rollback()
        {
            Context.ExecuteCommand("ROLLBACK");
        }
    }
}
