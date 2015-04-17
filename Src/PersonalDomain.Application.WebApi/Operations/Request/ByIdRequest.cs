using System;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Request
{
    public class ByIdRequest : WebApiRequest, IByIdRequest
    {
        public Int32 Id { get; set; }
    }
}