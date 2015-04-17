using Application.WebApi.Operations.Query;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Operations.Request;
using PostDTO = PersonalDomain.Application.WebApi.Models.PostDTO;

namespace PersonalDomain.Application.WebApi.Operations.Query
{
    public class GetPost : WebApiQuery<ByIdRequest, PostDTO>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override PostDTO Execute(ByIdRequest request)
        {
            return (PostDTO)BloggingApplicationService.GetPost(request.Id);
        }
    }
}