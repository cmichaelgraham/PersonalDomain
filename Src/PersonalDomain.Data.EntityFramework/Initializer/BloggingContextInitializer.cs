using System;
using System.Linq;
using Data.EntityFramework.Initializer;
using PersonalDomain.Data.Blogging.Initializer;
using PersonalDomain.Data.Context;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Initializer
{
    public class BloggingContextInitializer : ContextInitializer<BloggingContext>, IBloggingContextInitializer  
    {
        private BloggingContext _context { get; set; }

        public void InitializeAuthors()
        {
            _context.Authors.Add(new Author { FirstName = "James", LastName = "Chadwick", Tagline = "Tagline", Bio = "James Chadwick Bio", InsertDate = DateTime.Now });
            _context.SaveChanges();
        }

        public void InitializeComments()
        {
        }

        public void InitializePosts()
        {
            var authorId = _context.Authors.Select(a => a.Id).First();
            _context.Posts.Add(new Post { AuthorId = authorId, Title = "Man must explore", Subtitle = "Problems look mighty small from 150 miles up...", InsertDate = DateTime.Now });
            _context.Posts.Add(new Post { AuthorId = authorId, Title = "Don't waste my time", InsertDate = DateTime.Now });
            _context.Posts.Add(new Post { AuthorId = authorId, Title = "Science has not yet mastered prophecy", Subtitle = "We predict too much...", InsertDate = DateTime.Now });
            _context.Posts.Add(new Post { AuthorId = authorId, Title = "Failure is not an option", Subtitle = "Many say exploration is part of our destiny...", InsertDate = DateTime.Now });
            _context.SaveChanges();
        }

        protected override void Seed(BloggingContext context)
        {
            _context = context;

            InitializeAuthors();
            InitializePosts();
            InitializeComments();
        }
    }
}
