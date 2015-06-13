using System.Data.Entity;
using Framework.Core.Data.Context;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Blogging.Context
{
    public interface IBloggingContext : IContext
    {
        IDbSet<Author> Authors { get; }
        IDbSet<Comment> Comments { get; }
        IDbSet<Post> Posts { get; }
    }
}
