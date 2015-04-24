using Application.Seedwork.Operations.Command;
using Application.WebApi.Operations.Response;

namespace Application.WebApi.Operations.Command
{
    public abstract class WebApiCommand<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                               ICommand<TRequest, TResponse> where TRequest : class
                                                                                             where TResponse : WebApiResponse
    {

    }
}