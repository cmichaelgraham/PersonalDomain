using System.Web.Http;

namespace PersonalDomain.Application.WebApi.Configuration
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("Operation", "api/{*operationId}", new { controller = "PersonalDomain", action = "Execute" });
        }
    }
}
