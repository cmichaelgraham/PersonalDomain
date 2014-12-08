using Data.Seedwork;

namespace Application.Seedwork
{
    public interface IController<TContext> where TContext : IContext
    {
        IUnitOfWork<TContext> UnitOfWork { get; }
    }
}
