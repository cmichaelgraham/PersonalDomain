using Application.WebApi.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostSummaryCount : WebApiQuery<ByIdRequest, PostSummaryCountDTO>, IGetPostSummaryCount<ByIdRequest, PostSummaryCountDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryCountDTO Execute(ByIdRequest request)
        {
            return null;
        }
    }
}