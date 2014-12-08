using Application.Seedwork.Operations.Response;

namespace Application.Seedwork.Operations.Command
{
    public interface ICommand<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : class
                                                                                     where TResponse : class, IResponse
    {
        TResponse Execute(TRequest request);
    }
}