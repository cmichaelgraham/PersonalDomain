using System;
using Application.Seedwork.Operations;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        PostDTO GetPost(Int32 postId);
        Int32 GetPostCount();
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize);
        Response SavePost(PostDTO post);
        Response SaveComment(CommentDTO comment);
    }
}
