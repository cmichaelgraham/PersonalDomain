using System;
using System.Collections.Generic;
using Domain.Seedwork.Entities;

namespace PersonalDomain.Domain.Blogging.Post
{
    public class Author : Entity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public String Tagline { get; set; }
        public String Bio { get; set; }

        public IList<Post> Posts { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
