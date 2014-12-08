using Application.Seedwork.Operations.Query;

namespace Application.WebApi.Operations.Query
{
    public abstract class WebApiQuery<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                             IQuery<TRequest, TResponse> where TRequest : class
                                                                                         where TResponse : class
    {
    }
}