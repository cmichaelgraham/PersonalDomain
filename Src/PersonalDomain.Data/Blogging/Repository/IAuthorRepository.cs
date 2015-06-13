using System;
using Framework.Core.Data.Repository;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Blogging.Repository
{
    public interface IAuthorRepository : IRepository<Author, IBloggingContext>
    {
        TResult SelectById<TResult>(Int32 id, Func<Author, TResult> selector);
    }
}
