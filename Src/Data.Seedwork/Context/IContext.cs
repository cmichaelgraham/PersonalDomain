using System;

namespace Data.Seedwork.Context
{
    public interface IContext: IDisposable
    {
        void ExecuteCommand(String sqlCommand, params Object[] parameters);
        void MapEntities();
    }
}
