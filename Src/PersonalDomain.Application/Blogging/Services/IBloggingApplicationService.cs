using System;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Response;
using PersonalDomain.Data.Blogging.Repository;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        IPostRepository PostRepository { get; }

        IPostDTO GetPost(Int32 postId);
        IPostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize = 25);
        //Int32 GetPostSummaryCount();
        IOperationResponse SavePost(IPostDTO post);
        IOperationResponse SaveComment(Int32 postId, ICommentDTO comment);
    }
}
