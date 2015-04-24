using Application.WebApi.Operations.Query;
using Application.WebApi.Operations.Request;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;

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