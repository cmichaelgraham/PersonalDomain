using System;
using Application.Seedwork.Operations.Response;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        PostDTO GetPost(Int32 postId);
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize = 25);
        //Int32 GetPostSummaryCount();
        Response SavePost(PostDTO post);
        Response SaveComment(CommentDTO comment);
    }
}
