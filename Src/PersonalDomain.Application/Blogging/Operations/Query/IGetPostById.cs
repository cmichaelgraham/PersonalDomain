﻿using Framework.Core.Application.Operations;
using TypeScriptGenerator.Seedwork.Attributes;

namespace PersonalDomain.Application.Blogging.Operations
{
    [ApiOperation("BlogDataService")]
    public interface IGetPostById<TRequest, TResponse> : IQuery<TRequest, TResponse> where TRequest : Request 
                                                                                     where TResponse : class
    {
    }
}