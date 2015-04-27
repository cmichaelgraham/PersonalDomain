using Application.Seedwork.Operations;

namespace Application.WebApi.Operations
{
    public abstract class WebApiCommand<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                               ICommand<TRequest, TResponse> where TRequest : class
                                                                                             where TResponse : WebApiResponse
    {

    }
}