using Framework.Application.WebApi.Controllers;
using PersonalDomain.Data.Blogging.Context;

namespace PersonalDomain.Application.Controllers
{
    public class PersonalDomainController : WebApiController<IBloggingContext>
    {
    }
}