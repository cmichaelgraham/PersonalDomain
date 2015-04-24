using Application.WebApi.Operations.Query;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPost : WebApiQuery<ByIdRequest, PostDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDTO Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPost(request.Id);
        }
    }
}