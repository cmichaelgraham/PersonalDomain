using System;
using Framework.Application.Owin.Operations;

namespace PersonalDomain.Application.Operations.Request
{
    public class GetPostIndexByPageRequest : OwinRequest
    {
        public Int32 PageId { get; set; }
        public Int32 PageSize { get; set; }
    }
}