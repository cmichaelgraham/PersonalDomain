using System;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.WebApi.Operations.Request
{
    public class SaveCommentRequest : WebApiRequest
    {
        public Int32 PostId { get; set; }
        public CommentDTO Comment { get; set; }
    }
}