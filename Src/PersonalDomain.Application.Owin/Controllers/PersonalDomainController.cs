using Application.Owin.Controllers;
using PersonalDomain.Data.Blogging.Context;

namespace PersonalDomain.Application.Controllers
{
    public class PersonalDomainController : OwinApplicationController<IBloggingContext>
    {

    }
}