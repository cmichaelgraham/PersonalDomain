using Domain.Seedwork.Entities;

namespace Data.Seedwork
{
    public interface IDataMapper<TEntity> where TEntity : Entity
    {
        void Map();
    }
}
