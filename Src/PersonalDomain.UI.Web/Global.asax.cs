using Autofac.Integration.Mvc;
using PersonalDomain.Application.WebApi;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PersonalDomain.Application.WebApi.Infrastructure;

namespace PersonalDomain.UI.Web
{
    public class Global : PersonalDomainWebApiApplication
    {
        protected override void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            base.Application_Start();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var dependencyResolver = new PersonalDomainWebApiDependencyResolver();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(dependencyResolver.Container));
        }
    }
}