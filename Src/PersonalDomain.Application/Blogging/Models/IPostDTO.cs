using System;
using System.Collections.Generic;

namespace PersonalDomain.Application.Blogging.Models
{
    public interface IPostDTO
    {
        Int32 Id { get; set; }
        String Title { get; set; }
        String Subtitle { get; set; }
        String Content { get; set; }
        IList<ICommentDTO> Comments { get; set; }
    }
}
