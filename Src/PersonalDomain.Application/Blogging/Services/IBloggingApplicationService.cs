using System;
using Application.Seedwork.Operations.Response;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Data.Blogging.Repository;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        IPostRepository PostRepository { get; }

        PostDTO GetPost(Int32 postId);
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber);
        IResponse SavePost(PostDTO post);
        IResponse SaveComment(Int32 postId, CommentDTO comment);
    }
}
