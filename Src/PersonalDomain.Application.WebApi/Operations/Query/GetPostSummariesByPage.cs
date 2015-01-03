using System;
using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPostSummariesByPage : WebApiQuery<ByIdRequest, PostSummaryDTO[]>
    {
        public IBloggingApplicationService BloggingAPplicationService { get; set; }

        public override PostSummaryDTO[] Execute(ByIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}