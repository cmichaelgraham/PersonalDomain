using Data.EntityFramework.UnitOfWork;
using PersonalDomain.Data.Blogging.Context;

namespace PersonalDomain.Data.UnitOfWork
{
    public class BloggingUnitOfWork : UnitOfWork<IBloggingContext>
    {
        public BloggingUnitOfWork(IBloggingContext context) : base(context)
        {
        }
    }
}
