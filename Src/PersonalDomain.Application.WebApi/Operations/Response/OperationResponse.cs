using System;
using Framework.Application.WebApi.Operations;

namespace PersonalDomain.Application.Operations.Response
{
    public class OperationResponse : WebApiResponse
    {
        public override Boolean IsSuccess { get; set; }
    }
}