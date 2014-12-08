using Application.Seedwork.Operations;

namespace Application.WebApi.Operations
{
    public abstract class WebApiOperation<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : class
                                                                                                 where TResponse : class
    {
        public abstract TResponse Execute(TRequest request);
    }
}