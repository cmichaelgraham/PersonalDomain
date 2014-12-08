using System;

namespace Application.WebApi.Controllers
{
    public class WebApiMethod
    {
        public Type Operation { get; set; }
        public Type Request { get; set; }
        public Type Response { get; set; }
    }
}