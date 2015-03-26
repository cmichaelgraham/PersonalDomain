using Application.Seedwork;
using Application.WebApi.Controllers;
using Application.WebApi.Infrastructure;
using Autofac;
using Data.Seedwork;
using PersonalDomain.Application.Blogging.Models;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.WebApi.Controllers;
using PersonalDomain.Application.WebApi.Operations.Command;
using PersonalDomain.Application.WebApi.Operations.Query;
using PersonalDomain.Application.WebApi.Operations.Request;
using PersonalDomain.Application.WebApi.Operations.Response;
using PersonalDomain.Application.WebApi.Services;
using PersonalDomain.Data.Blogging.DbContext;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Data.EntityFramework.Context;
using PersonalDomain.Data.EntityFramework.Repository;
using PersonalDomain.Data.EntityFramework.UnitOfWork;

namespace PersonalDomain.Application.WebApi.Infrastructure
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
            _webApiMethodMap.Add("SaveComment", new WebApiMethod { Operation = typeof(SaveComment), Request = typeof(SaveCommentRequest), Response = typeof(OperationResponse) });
            _webApiMethodMap.Add("SavePost", new WebApiMethod { Operation = typeof(SavePost), Request = typeof(PostDTO), Response = typeof(OperationResponse) });
        }
    }
}