using System.Web.Http;
using Application.WebApi;
using PersonalDomain.Application.WebApi.Configuration;


namespace PersonalDomain.Application.WebApi
{
    public class PersonalDomainWebApiApplication : WebApiApplication
    {
        protected override void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
