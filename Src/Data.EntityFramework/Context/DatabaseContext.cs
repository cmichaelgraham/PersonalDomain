using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Data.Seedwork.Context;

namespace Data.EntityFramework.Context
{
    public abstract class DatabaseContext : DbContext, IContext
    {
        protected DbModelBuilder ModelBuilder { get; set; }

        public void ExecuteCommand(String sqlCommand, params Object[] parameters)
        {
            Database.ExecuteSqlCommand(sqlCommand, parameters);
        }
        public abstract void MapEntities();
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelBuilder = modelBuilder;

            ModelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            ModelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            MapEntities();

            base.OnModelCreating(ModelBuilder);
        }
        public new virtual void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
