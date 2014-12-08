using Application.WebApi.Controllers;
using PersonalDomain.Data.Blogging.DbContext;

namespace PersonalDomain.Application.WebApi.Controllers
{
    public class PersonalDomainController : WebApiController<IBloggingContext>
    {
    }
}