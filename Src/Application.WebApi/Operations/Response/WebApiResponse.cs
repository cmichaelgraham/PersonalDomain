using System;
using Application.Seedwork.Operations.Response;

namespace Application.WebApi.Operations.Response
{
    public abstract class WebApiResponse : IResponse
    {
        public Boolean IsSuccess { get; set; }
    }
}