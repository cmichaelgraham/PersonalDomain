using Application.Seedwork.Operations.Query;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Request;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.Blogging.Operations.Query
{
    public interface IGetPostSummaryCount : IQuery<IByIdRequest, IPostSummaryCountDTO>
    {
        IBloggingApplicationService BloggingApplicationService { get; }
    }
}