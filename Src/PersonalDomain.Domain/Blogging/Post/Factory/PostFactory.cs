using System;

namespace PersonalDomain.Domain.Blogging.Post
{
    public static class PostFactory
    {
        public static Post Create(Int32 id, Int32 authorId, String title, String subtitle, String content)
        {
            return new Post
            {
                Id = id,
                AuthorId = authorId,
                Title = title,
                Subtitle = subtitle,
                Content = content
            };
        }
    }
}
