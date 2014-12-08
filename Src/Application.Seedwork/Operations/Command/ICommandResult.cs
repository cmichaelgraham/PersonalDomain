using System;

namespace Application.Seedwork.Operations.Command
{
    public interface ICommandResult
    {
        Boolean IsSuccess { get; set; }
    }
}
