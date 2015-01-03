using System;
using System.Collections.Generic;
using Domain.Seedwork.Entities;

namespace PersonalDomain.Domain.Blogging.Post
{
    public class Post : Entity
    {
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Content { get; set; }
        
        public Author Author { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
