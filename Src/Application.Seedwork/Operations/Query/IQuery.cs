namespace Application.Seedwork.Operations
{
    public interface IQuery<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : Request
                                                                                   where TResponse : class
    {
        TResponse Execute(TRequest request);
    }
}