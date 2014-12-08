namespace Application.Seedwork.Operations.Query
{
    public interface IQuery<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : class
                                                                                   where TResponse : class
    {
        TResponse Execute(TRequest request);
    }
}