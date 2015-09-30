using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Services
{
    public interface IBloggingApplicationService
    {
        void DeletePostById(Int32 id);
        AuthorDTO GetAuthorById(Int32 id);
        PostDetailDTO GetPostById(Int32 id);
        PostDetailDTO GetPostBySlug(String slug);
        Int32 GetPostCount();
        PostSummaryDTO[] GetPostSummaries(Int32? pageNumber, Int32? pageSize);
        void SavePost(PostDetailDTO post);
        void SaveComment(CommentDTO comment);
    }
}
