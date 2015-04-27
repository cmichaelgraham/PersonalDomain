using System;
using System.Web.Http;
using Application.Seedwork.Controllers;
using Application.WebApi.Infrastructure;
using Data.Seedwork.Context;
using Data.Seedwork.UnitOfWork;
using Newtonsoft.Json.Linq;

namespace Application.WebApi.Controllers
{
    public abstract class WebApiController<TContext> : ApiController, IController<TContext> where TContext : IContext
    {
        public virtual IUnitOfWork<TContext> UnitOfWork { get; private set; }

        [HttpPost]
        public virtual Object Execute(String operationId, [FromBody] JObject body)
        {
            var webApiMethod = WebApiDependencyResolver.GetWebApiMethodByName(operationId);
            var request = ((body == null) ? Activator.CreateInstance(webApiMethod.Request) : body.ToObject(webApiMethod.Request));

            var genericExecuteMethod = GetType().GetMethod("ExecuteOperation");
            var methodInfo = genericExecuteMethod.MakeGenericMethod(webApiMethod.Request, webApiMethod.Response);
            return methodInfo.Invoke(this, new[] { webApiMethod, request });
        }

        public Object ExecuteOperation<TRequest, TResponse>(WebApiMethod method, Object request) where TRequest : class
                                                                                                 where TResponse: class
        {
            //$jchadwick- TODO: Fix Unit of Work
            UnitOfWork = WebApiDependencyResolver.Resolve<IUnitOfWork<TContext>>();
            var operation = WebApiDependencyResolver.ResolveOperation<TRequest, TResponse>(method.Operation);
            //UnitOfWork.BeginTransaction();

            try
            {
                var response = operation.Execute((TRequest)request);
                //UnitOfWork.Commit();
                return response;
            }
            catch (Exception)
            {
                UnitOfWork.Rollback();
                throw new ApplicationException();
            }
        }
    }
}