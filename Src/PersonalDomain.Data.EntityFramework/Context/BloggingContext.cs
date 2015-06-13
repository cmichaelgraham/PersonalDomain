using System.Data.Entity;
using Framework.DataAcess.EntityFramework.Context;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Data.DataMapper;
using PersonalDomain.Data.Initializer;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Context
{
    public class BloggingContext : DatabaseContext, IBloggingContext
    {
        public IDbSet<Author> Authors { get; set; }
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        public BloggingContext()
        {
            Database.SetInitializer(new BloggingContextInitializer());
        }

        public override void MapEntities()
        {
            ModelBuilder.Configurations.Add(new AuthorDataMapper());
            ModelBuilder.Configurations.Add(new CommentDataMapper());
            ModelBuilder.Configurations.Add(new PostDataMapper());
        }
    }
}
