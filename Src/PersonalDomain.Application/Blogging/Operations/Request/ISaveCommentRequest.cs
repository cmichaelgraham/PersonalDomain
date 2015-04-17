using System;
using Application.Seedwork.Operations.Request;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Operations.Request
{
    public interface ISaveCommentRequest : IRequest
    {
        Int32 PostId { get; }
        ICommentDTO Comment { get; }
    }
}