using System;
using Application.Seedwork.Operations.Command;

namespace Application.WebApi.Operations.Command
{
    public abstract class WebApiCommandResult : ICommandResult
    {
        public abstract Boolean IsSuccess { get; set; }
    }
}