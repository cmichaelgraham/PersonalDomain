using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.WebApi.Models
{
    public class CommentDTO : ICommentDTO
    {
        public Int32 Id { get; set; }
        public Int32 UserId { get; set; }
        public Int32 UserName { get; set; }
        public String Content { get; set; }
    }
}
