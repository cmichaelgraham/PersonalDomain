using Framework.Core.Application.Attributes;
using Framework.Core.Application.Operations;
using TypeScriptGenerator.Seedwork.Attributes;

namespace PersonalDomain.Application.Blogging.Operations
{
    [Authorize]
    [ApiOperation("BlogService")]
    public interface ISavePost<TRequest, TResponse> : ICommand<TRequest, TResponse> where TRequest : class 
                                                                                    where TResponse : Response
    {
    }
}