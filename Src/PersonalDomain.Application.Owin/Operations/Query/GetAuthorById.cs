﻿using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;

namespace PersonalDomain.Application.Operations
{
    public class GetAuthorById : OwinQuery<ByIdRequest, AuthorDTO>, IGetAuthorById<ByIdRequest, AuthorDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override AuthorDTO Execute(ByIdRequest request)
        {
            return BloggingApplicationService.GetAuthorById(request.Id);
        }
    }
}