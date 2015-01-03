using System;
using Application.Seedwork.Operations.Response;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Response;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Application.WebApi.Services
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
            return PostRepository.SelectById(postId, p => new PostDTO{ Id = p.Id, Title = p.Title, Content = p.Content });
        }

        public PostSummaryDTO[] GetPostSummariesByPage(int pageNumber)
        {
            //return PostRepository.Select(p => new PostSummaryDTO{ Title = p.Title, Subtitle = p.Subtitle })
            throw new NotImplementedException();
        }

        public IResponse SavePost(PostDTO post)
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

        public IResponse SaveComment(Int32 postId, CommentDTO comment)
        {
            var post = PostRepository.SelectById(postId, p => new PostDTO());
            post.Comments.Add(comment);
            return new OperationResponse { IsSuccess = true };
        }
    }
}