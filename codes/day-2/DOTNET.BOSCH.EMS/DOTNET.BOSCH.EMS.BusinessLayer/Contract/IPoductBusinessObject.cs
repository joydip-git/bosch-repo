using DOTNET.BOSCH.EMS.BusinessEntities;
using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.BusinessLayer.Contract
{
    public interface IPoductBusinessObject : IBusinessObject<Product>
    {
        IEnumerable<Product> FetchProductsByCategoryId(int catgeoryId);
    }
}
