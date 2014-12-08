using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Application.Seedwork.Operations;
using Application.WebApi.Controllers;
using PersonalDomain.Infrastructure.IoC;

namespace Application.WebApi.Infrastructure
{
    public abstract class WebApiDependencyResolver : AutofacContainer
    {
        protected static readonly IDictionary<String, WebApiMethod> _webApiMethodMap = new Dictionary<String, WebApiMethod>();

        public static WebApiMethod GetWebApiMethodByName(String name)
        {
            if (!_webApiMethodMap.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            return _webApiMethodMap[name];
        }

        public static T Resolve<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
        public static IOperation<TResponse, TRequest> ResolveOperation<TResponse, TRequest>(Type type) where TResponse : class 
                                                                                                       where TRequest  : class

        {
            return DependencyResolver.Current.GetService(type) as IOperation<TResponse, TRequest>;
        }
    }
}