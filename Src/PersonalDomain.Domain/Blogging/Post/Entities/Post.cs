﻿using System;
using System.Collections.Generic;
using Framework.Core.Domain.Entities;

namespace PersonalDomain.Domain.Blogging.Post
{
    public class Post : Entity
    {
        public Int32 AuthorId { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Slug { get; set; }
        public String Content { get; set; }
        
        public Author Author { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
