using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public interface ICommentDTO
    {
        Int32 Id { get; }
        Int32 UserId { get; }
        Int32 UserName { get; }
        String Content { get; }
    }
}
