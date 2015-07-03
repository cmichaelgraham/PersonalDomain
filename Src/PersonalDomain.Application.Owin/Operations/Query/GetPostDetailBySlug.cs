using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostDetailBySlug : OwinQuery<GetPostDetailBySlugRequest, PostDTO>, IGetPostDetailBySlug<GetPostDetailBySlugRequest, PostDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDTO Execute(GetPostDetailBySlugRequest request)
        {
            return BloggingApplicationService.GetPost(request.Slug);
        }
    }
}