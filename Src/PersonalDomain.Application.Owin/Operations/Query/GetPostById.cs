using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostById : OwinQuery<ByIdRequest, PostDTO>, IGetPostBySlug<ByIdRequest, PostDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDTO Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPostById(request.Id);
        }
    }
}