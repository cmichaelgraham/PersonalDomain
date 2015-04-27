using System.Web.Http;

namespace PersonalDomain.Application.Configuration
{
    public static class PersonalDomainWebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("Operation", "api/{*operationId}", new { controller = "PersonalDomain", action = "Execute" });
        }
    }
}
