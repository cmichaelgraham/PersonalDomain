using System;
using System.Collections.Generic;

namespace PersonalDomain.Application.Blogging.Models
{
    public class PostDTO
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Slug { get; set; }
        public String Content { get; set; }
        public IList<CommentDTO> Comments { get; set; }
    }
}
