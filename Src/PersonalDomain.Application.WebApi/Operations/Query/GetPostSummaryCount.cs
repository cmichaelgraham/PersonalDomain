using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;
using PostSummaryCountDTO = PersonalDomain.Application.WebApi.Models.PostSummaryCountDTO;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPostSummaryCount : WebApiQuery<ByIdRequest, PostSummaryCountDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryCountDTO Execute(ByIdRequest request)
        {
            return null;
        }
    }
}