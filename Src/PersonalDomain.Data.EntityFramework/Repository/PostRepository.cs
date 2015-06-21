using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Framework.DataAccess.EntityFramework.Repository;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Repository
{
    public class PostRepository : BaseRepository<Post, IBloggingContext>, IPostRepository
    {
        public PostRepository(IBloggingContext context) : base(context)
        {
        }

        public override void Add(Post entity)
        {
            entity.InsertDate = DateTime.Now;

            Context.Posts.Add(entity);
        }

        public override void Delete(Post entity)
        {
            Context.Posts.Remove(entity);
        }

        public override IEnumerable<TResult> Select<TResult>(Func<Post, TResult> selector)
        {
            return Context.Posts.Include("Author").Select(selector);
        }

        public TResult SelectById<TResult>(Int32 id, Func<Post, TResult> selector)
        {
            return Context.Posts.Where(p => p.Id == id).Select(selector).Single();
        }

        public override void Update(Post entity)
        {
            var dbPost = Context.Posts.Single(p => p.Id == entity.Id);
            dbPost.Title = entity.Title;
            dbPost.Subtitle = entity.Subtitle;
            dbPost.Content = entity.Content;
            dbPost.UpdateDate = DateTime.Now;
        }
    }
}
