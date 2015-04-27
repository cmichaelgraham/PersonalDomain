using Domain.Seedwork.Entities;

namespace Data.Seedwork.DataMapper
{
    public interface IDataMapper<TEntity> where TEntity : Entity
    {
        void Map();
    }
}
