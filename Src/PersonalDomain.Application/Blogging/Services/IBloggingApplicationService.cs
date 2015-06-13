using System;
using Framework.Core.Application.Operations;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        AuthorDTO GetAuthor(Int32 id);
        PostDTO GetPost(Int32 id);
        Int32 GetPostCount();
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize);
        Response SavePost(PostDTO post);
        Response SaveComment(CommentDTO comment);
    }
}
