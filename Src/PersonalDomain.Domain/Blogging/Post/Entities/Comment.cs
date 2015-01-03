using System;
using Domain.Seedwork.Entities;

namespace PersonalDomain.Domain.Blogging.Post
{
    public class Comment : Entity
    {
        public Int32 PostId { get; set; }
        public Int32 AuthorId { get; set; }
        public String Content { get; set; }

        public Author Author { get; set; }
    }
}
