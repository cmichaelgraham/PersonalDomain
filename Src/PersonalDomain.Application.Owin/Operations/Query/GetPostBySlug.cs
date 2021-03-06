﻿using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetPostBySlug : OwinQuery<GetPostDetailBySlugRequest, PostDetailDTO>, IGetPostBySlug<GetPostDetailBySlugRequest, PostDetailDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDetailDTO Execute(GetPostDetailBySlugRequest request)
        {
            return BloggingApplicationService.GetPostBySlug(request.Slug);
        }
    }
}