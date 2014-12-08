using System.Web;

namespace Application.WebApi
{
    public abstract class WebApiApplication : HttpApplication
    {
        protected abstract void Application_Start();
    }
}
