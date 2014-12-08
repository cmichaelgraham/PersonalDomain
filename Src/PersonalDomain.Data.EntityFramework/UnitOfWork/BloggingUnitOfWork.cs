using Data.EntityFramework.UnitOfWork;
using PersonalDomain.Data.Blogging.DbContext;

namespace PersonalDomain.Data.EntityFramework.UnitOfWork
{
    public class BloggingUnitOfWork : UnitOfWork<IBloggingContext>
    {
        public BloggingUnitOfWork(IBloggingContext context) : base(context)
        {
        }
    }
}
