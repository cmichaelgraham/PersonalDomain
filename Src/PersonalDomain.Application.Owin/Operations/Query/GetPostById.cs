using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostById : OwinQuery<ByIdRequest, PostDetailDTO>, IGetPostBySlug<ByIdRequest, PostDetailDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDetailDTO Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPostById(request.Id);
        }
    }
}