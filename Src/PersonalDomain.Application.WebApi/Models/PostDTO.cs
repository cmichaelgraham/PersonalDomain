using System;
using System.Collections.Generic;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.WebApi.Models
{
    public class PostDTO : IPostDTO
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Content { get; set; }
        public IList<ICommentDTO> Comments { get; set; }
    }
}
