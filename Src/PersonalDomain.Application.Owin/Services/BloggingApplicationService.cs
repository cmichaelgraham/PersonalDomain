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

        public void DeletePostById(Int32 id)
        {
            PostRepository.DeleteById(id);
        }

        public AuthorDTO GetAuthorById(Int32 id)
        {
            return AuthorRepository.SelectById(id, a => new AuthorDTO { FullName = a.FirstName, Tagline = a.Tagline, Bio = a.Bio });
        }

        public PostDetailDTO GetPostById(Int32 id)
        {
            return PostRepository.SelectById(id, p => new PostDetailDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Slug = p.Slug, Content = p.Content });
        }

        public PostDetailDTO GetPostBySlug(String slug)
        {
            return PostRepository.SelectBySlug(slug, p => new PostDetailDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Slug = p.Slug, Content = p.Content });
        }

        public Int32 GetPostCount()
        {
            return PostRepository.Select(p => p.Id).Count();
        }

        public PostSummaryDTO[] GetPostSummaries(Int32? pageNumber, Int32? pageSize)
        {
            var page = pageNumber.HasValue ? pageNumber.Value : 1;
            var size = pageSize.HasValue ? pageSize.Value : 0;

            var query = PostRepository.Select(p => new PostSummaryDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Slug = p.Slug, PostedDate = p.InsertDate.ToShortDateString(), Author = p.Author.FullName })
                                      .Skip((page - 1) * size);

            if (size != 0)
                query = query.Take(size);

            return query.ToArray();
        }

        public void SavePost(PostDetailDTO post)
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
            var post = PostRepository.SelectById(comment.PostId, p => new PostDetailDTO());
            post.Comments.Add(comment);
        }
    }
}