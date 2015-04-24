using Application.Seedwork.Operations.Command;
using Application.Seedwork.Operations.Response;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.Blogging.Operations.Command
{
    public interface ISavePost : ICommand<PostDTO, Response>
    {
    }
}