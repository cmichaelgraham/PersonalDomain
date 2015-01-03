using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPostSummariesByPage : WebApiQuery<ByIdRequest, PostSummaryDTO[]>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryDTO[] Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetPostSummariesByPage(request.Id);
        }
    }
}