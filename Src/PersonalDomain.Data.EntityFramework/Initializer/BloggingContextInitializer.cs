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

            var randomNumberGenerator = new Random();
            var blogPostSeed = randomNumberGenerator.Next(25, 50);

            for (int i = 0; i < blogPostSeed; i++)
            {
                var title = String.Format("Blog Post {0}", i);
                var subTitle = String.Format("Sub Title For Blog Post {0}", i);

                _context.Posts.Add(new Post { AuthorId = authorId, Title = title, Subtitle = subTitle, InsertDate = DateTime.Now });
            }

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
