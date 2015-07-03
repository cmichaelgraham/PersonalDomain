using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        AuthorDTO GetAuthor(Int32 id);
        PostDTO GetPost(String slug);
        Int32 GetPostCount();
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize);
        void SavePost(PostDTO post);
        void SaveComment(CommentDTO comment);
    }
}
