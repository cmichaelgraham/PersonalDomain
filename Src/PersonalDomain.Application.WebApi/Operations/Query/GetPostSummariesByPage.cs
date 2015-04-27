using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostSummariesByPage : WebApiQuery<ByIdRequest, PostSummaryDTO[]>, IGetPostSummariesByPage<ByIdRequest, PostSummaryDTO[]>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryDTO[] Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPostSummariesByPage(request.Id);
        }
    }
}