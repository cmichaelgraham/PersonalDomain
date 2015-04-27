using System;
using System.Linq;
using Application.Seedwork.Operations;
using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Response;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Application.Services
{
    public class BloggingApplicationService : IBloggingApplicationService
    {
        public IPostRepository PostRepository { get; private set; }

        public BloggingApplicationService(IPostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public PostDTO GetPost(Int32 postId)
        {
            return PostRepository.SelectById(postId, p => new PostDTO{ Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Content = p.Content });
        }

        public PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize = 25)
        {
            return PostRepository.Select(p => new PostSummaryDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Author = p.Author.FullName, PostedDate = p.InsertDate.ToShortDateString()})
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToArray();
        }

        public Response SavePost(PostDTO post)
        {
            if (post.Id == 0)
            {
                PostRepository.Add(PostFactory.Create());
            }
            else
            {
                PostRepository.Update(PostFactory.Create());
            }

            return new OperationResponse { IsSuccess = true };
        }

        public Response SaveComment(CommentDTO comment)
        {
            var post = PostRepository.SelectById(comment.PostId, p => new PostDTO());
            post.Comments.Add(comment);
            return new OperationResponse { IsSuccess = true };
        }
    }
}