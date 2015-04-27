﻿using Application.Seedwork.Operations;
using TypeScriptGenerator.Seedwork.Attributes;

namespace PersonalDomain.Application.Blogging.Operations
{
    [ApiOperation("BlogService")]
    public interface ISavePost<TRequest, TResponse> : ICommand<TRequest, TResponse> where TRequest : class 
                                                                                    where TResponse : Response
    {
    }
}