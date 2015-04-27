using Data.Seedwork.Context;
using Data.Seedwork.UnitOfWork;

namespace Application.Seedwork
{
    public interface IController<TContext> where TContext : IContext
    {
        IUnitOfWork<TContext> UnitOfWork { get; }
    }
}
