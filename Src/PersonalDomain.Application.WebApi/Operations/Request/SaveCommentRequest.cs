using System;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Request
{
    public class SaveCommentRequest : WebApiRequest, ISaveCommentRequest
    {
        public Int32 PostId { get; set; }
        public ICommentDTO Comment { get; set; }
    }
}