using Application.Seedwork.Operations.Command;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Response;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.Blogging.Operations.Command
{
    public interface ISavePost : ICommand<IPostDTO, IOperationResponse>
    {
        IBloggingApplicationService BloggingApplicationService { get; }
    }
}