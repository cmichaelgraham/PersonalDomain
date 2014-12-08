namespace PersonalDomain.Domain.Blogging.Post
{
    public class PostService : IPostService
    {
        public void AddComment(Post post, Comment comment)
        {
            post.Comments.Add(comment);
        }
    }
}
