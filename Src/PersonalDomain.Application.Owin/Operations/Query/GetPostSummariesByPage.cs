using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostSummariesByPage : OwinQuery<GetPostSummariesByPageRequest, PostIndexDTO>, IGetPostSummariesByPage<GetPostSummariesByPageRequest, PostIndexDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostIndexDTO Execute(GetPostSummariesByPageRequest request)
        {
            var postSummaries = BloggingApplicationService.GetPostSummaries(request.PageId, request.PageSize);
            var postSummaryCount = BloggingApplicationService.GetPostCount();

            return new PostIndexDTO
            {
                PostSummaries = postSummaries,
                PostSummaryCount = postSummaryCount
            };
        }
    }
}