using Application.WebApi.Operations.Command;
using Application.WebApi.Operations.Response;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.WebApi.Operations.Command
{
    public class SavePost : WebApiCommand<PostDTO, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(PostDTO request)
        {
            return (OperationResponse) BloggingApplicationService.SavePost(request);
        }
    }
}