using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public class CommentDTO
    {
        public Int32 Id { get; set; }
        public Int32 UserId { get; set; }
        public Int32 UserName { get; set; }
        public String Content { get; set; }
    }
}
