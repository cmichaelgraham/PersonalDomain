using System;
using System.Linq;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Application.Services
{
    public class BloggingApplicationService : IBloggingApplicationService
    {
        public IAuthorRepository AuthorRepository { get; private set; }
        public IPostRepository PostRepository { get; private set; }

        public BloggingApplicationService(IAuthorRepository authorRepository, IPostRepository postRepository)
        {
            AuthorRepository = authorRepository;
            PostRepository = postRepository;
        }

        public AuthorDTO GetAuthorById(Int32 id)
        {
            return AuthorRepository.SelectById(id, a => new AuthorDTO { FullName = a.FirstName, Tagline = a.Tagline, Bio = a.Bio });
        }

        public PostDTO GetPostById(Int32 id)
        {
            return PostRepository.SelectById(id, p => new PostDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Content = p.Content });
        }

        public PostDTO GetPostBySlug(String slug)
        {
            return PostRepository.SelectBySlug(slug, p => new PostDTO{ Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Content = p.Content });
        }

        public Int32 GetPostCount()
        {
            return PostRepository.Select(p => p.Id).Count();
        }

        public PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize = 25)
        {
            return PostRepository.Select(p => new PostSummaryDTO { Id = p.Id, Slug = p.Slug, Title = p.Title, Subtitle = p.Subtitle, Author = p.Author.FullName, PostedDate = p.InsertDate.ToShortDateString()})
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToArray();
        }

        public void SavePost(PostDTO post)
        {
            var postEntity = PostFactory.Create(post.Id, 1, post.Title, post.Subtitle, post.Slug, post.Content);
            if (postEntity.Id == 0)
            {
                PostRepository.Add(postEntity);
            }
            else
            {
                PostRepository.Update(postEntity);
            }
        }

        public void SaveComment(CommentDTO comment)
        {
            var post = PostRepository.SelectById(comment.PostId, p => new PostDTO());
            post.Comments.Add(comment);
        }
    }
}