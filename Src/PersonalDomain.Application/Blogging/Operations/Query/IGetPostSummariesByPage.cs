using Application.Seedwork.Operations.Query;
using Application.Seedwork.Operations.Request;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Operations.Query
{
    public interface IGetPostSummariesByPage : IQuery<Request, PostSummaryDTO[]>
    {
    }
}