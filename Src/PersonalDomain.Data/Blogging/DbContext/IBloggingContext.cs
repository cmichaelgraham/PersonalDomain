﻿using System.Data.Entity;
using Data.Seedwork;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.Blogging.DbContext
{
    public interface IBloggingContext : IContext
    {
        IDbSet<Comment> Comments { get; }
        IDbSet<Post> Posts { get; }
    }
}
