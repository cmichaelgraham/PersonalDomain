using Framework.Core.Application.Operations;
using TypeScriptGenerator.Seedwork.Attributes;

namespace PersonalDomain.Application.Blogging.Operations
{
    [ApiOperation("BlogService")]
    public interface ISaveComment<TRequest, TResponse> : ICommand<TRequest, TResponse> where TRequest : class 
                                                                                       where TResponse : Response
    {
    }
}