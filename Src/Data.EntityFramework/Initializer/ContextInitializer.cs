using System.Data.Entity;

namespace Data.EntityFramework.Initializer
{
    public abstract class ContextInitializer<TContext> : DropCreateDatabaseIfModelChanges<TContext> where TContext : DbContext
    {
    }
}
