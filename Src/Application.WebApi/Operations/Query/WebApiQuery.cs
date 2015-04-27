using Application.Seedwork.Operations;

namespace Application.WebApi.Operations
{
    public abstract class WebApiQuery<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                             IQuery<TRequest, TResponse> where TRequest : WebApiRequest
                                                                                         where TResponse : class
    {
    }
}