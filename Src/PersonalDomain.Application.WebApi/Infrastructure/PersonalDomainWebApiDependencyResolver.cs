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
            ContainerBuilder.RegisterType<GetPost>().PropertiesAutowired();
            ContainerBuilder.RegisterType<GetPostSummariesByPage>().PropertiesAutowired();
            ContainerBuilder.RegisterType<GetPostSummaryCount>().PropertiesAutowired();
            ContainerBuilder.RegisterType<SaveComment>().PropertiesAutowired();
            ContainerBuilder.RegisterType<SavePost>().PropertiesAutowired();
        }

        public override void RegisterOperations()
        {
            //$jchadwick- TODO: Update so Operations are Registered via Reflection
            _webApiMethodMap.Add("GetPost", new WebApiMethod{ Operation = typeof(GetPost), Request = typeof(ByIdRequest), Response = typeof(PostDTO)});
            _webApiMethodMap.Add("GetPostSummariesByPage", new WebApiMethod { Operation = typeof(GetPostSummariesByPage), Request = typeof(ByIdRequest), Response = typeof(PostSummaryDTO[]) });
            _webApiMethodMap.Add("GetPostSummaryCount", new WebApiMethod { Operation = typeof(GetPostSummaryCount), Request = typeof(NullRequest), Response = typeof(PostSummaryCountDTO) });
            _webApiMethodMap.Add("SaveComment", new WebApiMethod { Operation = typeof(SaveComment), Request = typeof(CommentDTO), Response = typeof(OperationResponse) });
            _webApiMethodMap.Add("SavePost", new WebApiMethod { Operation = typeof(SavePost), Request = typeof(PostDTO), Response = typeof(OperationResponse) });
        }
    }
}