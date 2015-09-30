using Framework.Application.Owin.Operations;
using PersonalDomain.Application.Blogging.Operations;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Operations.Request;
using PersonalDomain.Application.Operations.Response;

namespace PersonalDomain.Application.Operations
{
    public class DeletePostById : OwinCommand<ByIdRequest, OperationResponse>, IDeletePostById<ByIdRequest, OperationResponse>
    {
        public IBloggingApplicationService BloggingApplicationService { get; set; }

        public override OperationResponse Execute(ByIdRequest request)
        {
            BloggingApplicationService.DeletePostById(request.Id);
            return new OperationResponse { IsSuccess = true };
        }
    }
}