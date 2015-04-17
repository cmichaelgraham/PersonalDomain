using System;
using Application.Seedwork.Operations.Request;

namespace PersonalDomain.Application.Blogging.Operations.Request
{
    public interface IByIdRequest : IRequest
    {
        Int32 Id { get; }
    }
}