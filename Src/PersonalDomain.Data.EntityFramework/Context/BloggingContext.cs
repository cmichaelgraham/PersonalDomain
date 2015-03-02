using System.Data.Entity;
using Data.EntityFramework.Context;
using PersonalDomain.Data.Blogging.DbContext;
using PersonalDomain.Data.EntityFramework.DataMapper;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.EntityFramework.Context
{
    public class BloggingContext : DatabaseContext, IBloggingContext
    {
        public IDbSet<Author> Authors { get; set; }
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        public override void MapEntities()
        {
            ModelBuilder.Configurations.Add(new AuthorDataMapper());
            ModelBuilder.Configurations.Add(new CommentDataMapper());
            ModelBuilder.Configurations.Add(new PostDataMapper());
        }
    }
}
