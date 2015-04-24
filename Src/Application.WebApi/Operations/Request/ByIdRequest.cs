using System;

namespace Application.WebApi.Operations.Request
{
    public class ByIdRequest : WebApiRequest
    {
        public Int32 Id { get; set; }
    }
}