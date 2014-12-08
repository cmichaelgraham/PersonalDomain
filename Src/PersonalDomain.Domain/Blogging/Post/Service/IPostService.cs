namespace PersonalDomain.Domain.Blogging.Post
{
    public interface IPostService
    {
        void AddComment (Post post, Comment comment);
    }
}
