namespace Application.Seedwork.Operations.Command
{
    public interface ICommand<TRequest, TResponse> : IOperation<TRequest, TResponse> where TRequest : class
                                                                                     where TResponse : Response.Response
    {
        TResponse Execute(TRequest request);
    }
}