using System;

namespace Application.WebApi.Operations.Response
{
    public class OperationResponse : WebApiResponse
    {
        public override Boolean IsSuccess { get; set; }
    }
}