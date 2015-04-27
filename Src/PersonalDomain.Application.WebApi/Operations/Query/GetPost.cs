using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPost : WebApiQuery<ByIdRequest, PostDTO>, IGetPost<ByIdRequest, PostDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDTO Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPost(request.Id);
        }
    }
}