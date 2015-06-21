using System;
using Framework.Application.Owin.Operations;

namespace PersonalDomain.Application.Operations.Request
{
    public class ByIdRequest : OwinRequest
    {
        public Int32 Id { get; set; }
    }
}