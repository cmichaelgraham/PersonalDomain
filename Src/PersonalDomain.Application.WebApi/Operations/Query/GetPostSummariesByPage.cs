using Application.WebApi.Operations.Query;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;

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