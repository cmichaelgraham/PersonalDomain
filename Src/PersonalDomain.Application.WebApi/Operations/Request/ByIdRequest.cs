using System;
using Application.WebApi.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Request
{
    public class ByIdRequest : WebApiRequest
    {
        public Int32 Id { get; set; }
    }
}