using System.Web.Http;
using Autofac.Integration.WebApi;
using Framework.Application.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using PersonalDomain.Application.Configuration;
using PersonalDomain.Application.Infrastructure;

[assembly: OwinStartup(typeof(PersonalDomain.Application.Owin.PersonalDomainApplicationStartup))]
namespace PersonalDomain.Application.Owin
{
    public class PersonalDomainApplicationStartup : OwinApplicationStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            PersonalDomainWebApiConfig.Register(configuration);

            var dependencyResolver = new PersonalDomainOwinDependencyResolver();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(dependencyResolver.Container);
            app.UseAutofacMiddleware(dependencyResolver.Container);
            app.UseAutofacWebApi(configuration);

            ConfigureOAuth(app);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(configuration);
        }
        public override void ConfigureOAuth(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
