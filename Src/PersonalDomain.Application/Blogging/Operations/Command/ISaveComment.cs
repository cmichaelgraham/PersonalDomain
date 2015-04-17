using Application.Seedwork.Operations.Command;
using PersonalDomain.Application.Blogging.Operations.Request;
using PersonalDomain.Application.Blogging.Operations.Response;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.Blogging.Operations.Command
{
    public interface ISaveComment : ICommand<ISaveCommentRequest, IOperationResponse>
    {
        IBloggingApplicationService BloggingApplicationService { get; }
    }
}