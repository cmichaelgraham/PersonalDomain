using Application.Seedwork.Controllers;
using Application.WebApi.Controllers;
using Application.WebApi.Infrastructure;
using Autofac;
using Data.Seedwork.UnitOfWork;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Controllers;
using PersonalDomain.Application.Operations;
using PersonalDomain.Application.Operations.Request;
using PersonalDomain.Application.Operations.Response;
using PersonalDomain.Application.Services;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Data.Context;
using PersonalDomain.Data.Repository;
using PersonalDomain.Data.UnitOfWork;

namespace PersonalDomain.Application.Infrastructure
{
    public class PersonalDomainWebApiDependencyResolver : WebApiDependencyResolver
    {
        public override void RegisterComponents()
        {
            ContainerBuilder.RegisterType<BloggingContext>().As<IBloggingContext>();
            ContainerBuilder.RegisterType<BloggingUnitOfWork>().As<IUnitOfWork<IBloggingContext>>();
            ContainerBuilder.RegisterType<PostRepository>().As<IPostRepository>();
            ContainerBuilder.RegisterType<BloggingApplicationService>().As<IBloggingApplicationService>();
            ContainerBuilder.RegisterType<PersonalDomainController>().As<IController<IBloggingContext>>();
            
            //$jchadwick- TODO: Update so Operations are Registered via Reflection
            ContainerBuilder.RegisterType<GetPostDetailById>().PropertiesAutowired();
            ContainerBuilder.RegisterType<GetPostIndexByPage>().PropertiesAutowired();
            ContainerBuilder.RegisterType<SaveComment>().PropertiesAutowired();
            ContainerBuilder.RegisterType<SavePost>().PropertiesAutowired();
        }

        public override void RegisterOperations()
        {
            //$jchadwick- TODO: Update so Operations are Registered via Reflection
            _webApiMethodMap.Add("GetPostDetailById", new WebApiMethod { Operation = typeof(GetPostDetailById), Request = typeof(ByIdRequest), Response = typeof(PostDTO) });
            _webApiMethodMap.Add("GetPostIndexByPage", new WebApiMethod { Operation = typeof(GetPostIndexByPage), Request = typeof(GetPostIndexByPageRequest), Response = typeof(PostIndexDTO) });
            _webApiMethodMap.Add("SaveComment", new WebApiMethod { Operation = typeof(SaveComment), Request = typeof(CommentDTO), Response = typeof(OperationResponse) });
            _webApiMethodMap.Add("SavePost", new WebApiMethod { Operation = typeof(SavePost), Request = typeof(PostDTO), Response = typeof(OperationResponse) });
        }
    }
}