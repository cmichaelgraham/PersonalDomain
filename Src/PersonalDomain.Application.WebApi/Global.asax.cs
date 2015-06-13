using System.Web.Http;
using Framework.Application.WebApi;
using PersonalDomain.Application.Configuration;


namespace PersonalDomain.Application.WebApi
{
    public class PersonalDomainWebApiApplication : WebApiApplication
    {
        protected override void Application_Start()
        {
            GlobalConfiguration.Configure(PersonalDomainWebApiConfig.Register);
        }
    }
}
