using System.Data.Entity.ModelConfiguration;
using Data.Seedwork;
using Domain.Seedwork.Entities;

namespace Data.EntityFramework.DataMapper
{
    public abstract class EntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity>, IDataMapper<TEntity> where TEntity : Entity
    {
        protected EntityConfiguration()
        {
            HasKey(e => e.Id);
            Map();
        }

        public abstract void Map();
    }
}
