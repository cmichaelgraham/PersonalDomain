using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostSummaries : OwinQuery<NullRequest, PostSummaryDTO[]>, IGetPostSummaries<NullRequest, PostSummaryDTO[]>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryDTO[] Execute(NullRequest request)
        {
            return BloggingApplicationService.GetPostSummaries(null, null);
        }
    }
}