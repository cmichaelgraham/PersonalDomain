using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostIndexByPage : WebApiQuery<GetPostIndexByPageRequest, PostIndexDTO>, IGetPostIndexByPage<GetPostIndexByPageRequest, PostIndexDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostIndexDTO Execute(GetPostIndexByPageRequest request)
        {
            var postSummaries = BloggingApplicationService.GetPostSummariesByPage(request.PageId, request.PageSize);
            var postSummaryCount = BloggingApplicationService.GetPostCount();

            return new PostIndexDTO
            {
                PostSummaries = postSummaries,
                PostSummaryCount = postSummaryCount
            };
        }
    }
}