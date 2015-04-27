namespace Application.Seedwork.Operations
{
    public interface ICommand<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : class
                                                                                     where TResponse : Response
    {
        TResponse Execute(TRequest request);
    }
}