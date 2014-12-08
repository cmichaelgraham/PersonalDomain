using Application.WebApi.Operations.Command;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;
using PersonalDomain.Application.WebApi.Operations.Response;

namespace PersonalDomain.Application.WebApi.Operations.Command
{
    public class SaveComment : WebApiCommand<SaveCommentRequest, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; private set; }

        public SaveComment(IBloggingApplicationService bloggingApplicationService)
        {
            BloggingApplicationService = bloggingApplicationService;
        }

        public override OperationResponse Execute(SaveCommentRequest request)
        {
            return (OperationResponse)BloggingApplicationService.SaveComment(request.PostId, request.Comment);
        }
    }
}