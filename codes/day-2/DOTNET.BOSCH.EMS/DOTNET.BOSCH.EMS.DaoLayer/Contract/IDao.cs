using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.BOSCH.EMS.DaoLayer.Contract
{
    public interface IDao<T>
    {
        bool Add(T data);
        bool Update(T data);
        bool Delete(int id);
        T[] GetAll();
        T Get();
        T[] Search(string criteria);
    }
}
