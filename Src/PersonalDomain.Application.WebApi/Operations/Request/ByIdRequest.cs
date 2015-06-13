using System;
using Framework.Application.WebApi.Operations;

namespace PersonalDomain.Application.Operations.Request
{
    public class ByIdRequest : WebApiRequest
    {
        public Int32 Id { get; set; }
    }
}