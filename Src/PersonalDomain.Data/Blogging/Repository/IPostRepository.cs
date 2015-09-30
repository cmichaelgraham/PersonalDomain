using System;
using Framework.Core.Data.Repository;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Blogging.Repository
{
    public interface IPostRepository : IRepository<Post, IBloggingContext>
    {
        void DeleteById(Int32 id);
        TResult SelectById<TResult>(Int32 id, Func<Post, TResult> selector);
        TResult SelectBySlug<TResult>(String slug, Func<Post, TResult> selector);
    }
}
