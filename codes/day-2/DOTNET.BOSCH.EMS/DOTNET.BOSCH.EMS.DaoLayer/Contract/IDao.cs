using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.DaoLayer.Contract
{
    public interface IDao<T>
    {
        bool Add(T data);
        bool Update(T data);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T Get();
    }
}
