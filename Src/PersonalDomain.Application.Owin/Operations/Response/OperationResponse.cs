using System;
using Framework.Application.Owin.Operations;

namespace PersonalDomain.Application.Operations.Response
{
    public class OperationResponse : OwinResponse
    {
        public override Boolean IsSuccess { get; set; }
    }
}