using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Response;

namespace PersonalDomain.Application.Operations
{
    public class SavePost : WebApiCommand<PostDTO, OperationResponse>, ISavePost<PostDTO, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(PostDTO request)
        {
            return (OperationResponse) BloggingApplicationService.SavePost(request);
        }
    }
}