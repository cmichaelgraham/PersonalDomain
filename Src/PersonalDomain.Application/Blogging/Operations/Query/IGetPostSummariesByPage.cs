using Application.Seedwork.Operations.Query;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations.Request;
using PersonalDomain.Application.Blogging.Services;

namespace PersonalDomain.Application.Blogging.Operations.Query
{
    public interface IGetPostSummariesByPage : IQuery<IByIdRequest, IPostSummaryDTO[]>
    {
        IBloggingApplicationService BloggingApplicationService { get; }
    }
}