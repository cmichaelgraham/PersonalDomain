using System;
using System.Linq;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Response;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Response;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Domain.Blogging.Post;
using PostDTO = PersonalDomain.Application.WebApi.Models.PostDTO;
using PostSummaryDTO = PersonalDomain.Application.WebApi.Models.PostSummaryDTO;

namespace PersonalDomain.Application.WebApi.Services
{
    public class BloggingApplicationService : IBloggingApplicationService
    {
        public IPostRepository PostRepository { get; private set; }

        public BloggingApplicationService(IPostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public IPostDTO GetPost(Int32 postId)
        {
            return PostRepository.SelectById(postId, p => new PostDTO{ Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Content = p.Content });
        }

        public IPostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize = 25)
        {
            return PostRepository.Select(p => new PostSummaryDTO { Id = p.Id, Title = p.Title, Subtitle = p.Subtitle, Author = p.Author.FullName, PostedDate = p.InsertDate.ToShortDateString()})
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToArray();
        }

        public IOperationResponse SavePost(IPostDTO post)
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

        public IOperationResponse SaveComment(Int32 postId, ICommentDTO comment)
        {
            var post = PostRepository.SelectById(postId, p => new PostDTO());
            post.Comments.Add(comment);
            return new OperationResponse { IsSuccess = true };
        }
    }
}