using System;
using System.Linq;
using System.Reflection;
using Application.Seedwork.Controllers;
using Application.WebApi.Controllers;
using Application.WebApi.Infrastructure;
using Autofac;
using Data.Seedwork.UnitOfWork;
using PersonalDomain.Application.Blogging.Services;
using PersonalDomain.Application.Controllers;
using PersonalDomain.Application.Services;
using PersonalDomain.Data.Blogging.Context;
using PersonalDomain.Data.Blogging.Repository;
using PersonalDomain.Data.Context;
using PersonalDomain.Data.Repository;
using PersonalDomain.Data.UnitOfWork;
using TypeScriptGenerator.Seedwork.Attributes;

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
        }
        private void RegisterOperation(Type operation)
        {
            ContainerBuilder.RegisterType(operation).PropertiesAutowired();

            var requestType = operation.BaseType.GetGenericArguments()[0];
            var responseType = operation.BaseType.GetGenericArguments()[1];
            _webApiMethodMap.Add(operation.Name, new WebApiMethod { Operation = operation, Request = requestType, Response = responseType });
        }
        public override void RegisterOperations()
        {
            var apiOperations = Assembly.GetExecutingAssembly()
                                        .GetTypes()
                                        .Where(t => t.GetInterfaces().Any(i => i.GetCustomAttribute(typeof(ApiOperation)) != null))
                                        .ToArray();

            foreach (var apiOperation in apiOperations) {
                RegisterOperation(apiOperation);
            }
        }
    }
}