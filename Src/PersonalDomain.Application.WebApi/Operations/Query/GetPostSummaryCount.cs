﻿using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPostSummaryCount : WebApiQuery<ByIdRequest, PostSummaryCountDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostSummaryCountDTO Execute(ByIdRequest request)
        {
            return null;
            //return new PostSummaryCountDTO
            //{
            //    Count = BloggingApplicationService.GetPostSummaryCount()
            //};
        }
    }
}