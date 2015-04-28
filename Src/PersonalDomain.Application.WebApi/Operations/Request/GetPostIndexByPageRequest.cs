using System;
using Application.WebApi.Operations;

namespace PersonalDomain.Application.Operations.Request
{
    public class GetPostIndexByPageRequest : WebApiRequest
    {
        public Int32 PageId { get; set; }
        public Int32 PageSize { get; set; }
    }
}