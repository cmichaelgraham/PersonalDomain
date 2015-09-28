using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        AuthorDTO GetAuthorById(Int32 id);
        PostDTO GetPostById(Int32 id);
        PostDTO GetPostBySlug(String slug);
        Int32 GetPostCount();
        PostSummaryDTO[] GetPostSummariesByPage(Int32 pageNumber, Int32 pageSize);
        void SavePost(PostDTO post);
        void SaveComment(CommentDTO comment);
    }
}
