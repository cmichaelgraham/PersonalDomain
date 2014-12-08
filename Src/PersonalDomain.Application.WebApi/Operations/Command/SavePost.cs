using Application.WebApi.Operations.Command;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Response;

namespace PersonalDomain.Application.WebApi.Operations.Command
{
    public class SavePost : WebApiCommand<PostDTO, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(PostDTO request)
        {
            return (OperationResponse)BloggingApplicationService.SavePost(request);
        }
    }
}