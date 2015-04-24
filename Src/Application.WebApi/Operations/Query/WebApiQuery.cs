using Application.Seedwork.Operations.Query;
using Application.WebApi.Operations.Request;

namespace Application.WebApi.Operations.Query
{
    public abstract class WebApiQuery<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                             IQuery<TRequest, TResponse> where TRequest : WebApiRequest
                                                                                         where TResponse : class
    {
    }
}