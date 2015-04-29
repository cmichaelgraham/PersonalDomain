using System;
using System.Collections.Generic;
using System.Linq;
using Data.EntityFramework.Repository;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Repository
{
    public class AuthorRepository : BaseRepository<Author, IBloggingContext>, IAuthorRepository
    {
        public AuthorRepository(IBloggingContext context) : base(context)
        {
        }

        public override void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TResult> Select<TResult>(Func<Author, TResult> selector)
        {
            throw new NotImplementedException();
        }

        public TResult SelectById<TResult>(int id, Func<Author, TResult> selector)
        {
            return Context.Authors.Where(a => a.Id == id).Select(selector).Single();
        }

        public override void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
