using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;
using PostSummaryDTO = PersonalDomain.Application.WebApi.Models.PostSummaryDTO;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPostSummariesByPage : WebApiQuery<ByIdRequest, PostSummaryDTO[]>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryDTO[] Execute(ByIdRequest request)
        {
            return (PostSummaryDTO[])BloggingApplicationService.GetPostSummariesByPage(request.Id);
        }
    }
}