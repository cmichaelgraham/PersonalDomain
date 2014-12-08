using System;
using System.Linq;
using Data.EntityFramework.Repository;
using PersonalDomain.Data.Blogging.DbContext;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.EntityFramework.Repository
{
    public class PostRepository : BaseRepository<Post, IBloggingContext>, IPostRepository
    {
        public PostRepository(IBloggingContext context) : base(context)
        {
        }

        public override void Add(Post entity)
        {
            Context.Posts.Add(entity);
        }

        public override void Delete(Post entity)
        {
            Context.Posts.Remove(entity);
        }

        public override IQueryable<TResult> Select<TResult>(Func<Post, TResult> selector)
        {
            return Context.Posts.Select(selector).AsQueryable();
        }

        public TResult SelectById<TResult>(Int32 id, Func<Post, TResult> selector)
        {
            return Context.Posts.Where(p => p.Id == id).Select(selector).Single();
        }

        public override void Update(Post entity)
        {
        }
    }
}
