namespace PersonalDomain.Data.Blogging.Initializer
{
    public interface IBloggingContextInitializer
    {
        void InitializeAuthors();
        void InitializeComments();
        void InitializePosts();
    }
}
