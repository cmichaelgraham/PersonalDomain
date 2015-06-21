using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Response;

namespace PersonalDomain.Application.Operations
{
    public class SaveComment : OwinCommand<CommentDTO, OperationResponse>, ISaveComment<CommentDTO, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(CommentDTO request)
        {
            return (OperationResponse) BloggingApplicationService.SaveComment(request);
        }
    }
}