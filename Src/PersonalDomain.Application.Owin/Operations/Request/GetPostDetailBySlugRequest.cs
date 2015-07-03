using System;
using Framework.Application.Owin.Operations;

namespace PersonalDomain.Application.Operations.Request
{
    public class GetPostDetailBySlugRequest : OwinRequest
    {
        public String Slug { get; set; }
    }
}