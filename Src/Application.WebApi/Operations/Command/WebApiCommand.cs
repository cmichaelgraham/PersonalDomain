using Application.Seedwork.Operations.Command;
using Application.Seedwork.Operations.Response;

namespace Application.WebApi.Operations.Command
{
    public abstract class WebApiCommand<TRequest, TResponse> : WebApiOperation<TRequest, TResponse>,
                                                               ICommand<TRequest, TResponse> where TRequest : class
                                                                                             where TResponse : class, IResponse
    {

    }
}