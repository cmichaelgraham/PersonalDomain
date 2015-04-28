using Application.Seedwork.Operations;
using TypeScriptGenerator.Seedwork.Attributes;

namespace PersonalDomain.Application.Blogging.Operations
{
    [ApiOperation("BlogService")]
    public interface IGetPostDetailById<TRequest, TResponse> : IQuery<TRequest, TResponse> where TRequest : Request 
                                                                                           where TResponse : class
    {
    }
}