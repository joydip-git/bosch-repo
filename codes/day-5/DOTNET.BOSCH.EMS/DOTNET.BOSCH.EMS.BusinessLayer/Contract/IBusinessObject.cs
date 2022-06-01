using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.BusinessLayer.Contract
{
    public interface IBusinessObject<T>
    {
        bool Insert(T data);
        bool Modify(T data);
        bool Remove(int id);
        IEnumerable<T> FetchAll();
        T Fetch();
    }
}
