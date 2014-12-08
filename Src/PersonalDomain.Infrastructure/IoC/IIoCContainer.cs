namespace PersonalDomain.Infrastructure.IoC
{
    public interface IIoCContainer
    {
        void RegisterComponents();
        void RegisterOperations();
    }
}