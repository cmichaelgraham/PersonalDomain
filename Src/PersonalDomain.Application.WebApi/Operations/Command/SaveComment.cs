using Application.WebApi.Operations.Command;
using Application.WebApi.Operations.Response;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.WebApi.Operations.Command
{
    public class SaveComment : WebApiCommand<CommentDTO, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(CommentDTO request)
        {
            return (OperationResponse) BloggingApplicationService.SaveComment(request);
        }
    }
}