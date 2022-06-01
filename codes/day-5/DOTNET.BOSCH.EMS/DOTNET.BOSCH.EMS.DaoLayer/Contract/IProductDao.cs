using DOTNET.BOSCH.EMS.BusinessEntities;
using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.DaoLayer.Contract
{
    public interface IProductDao : IDao<Product>
    {
        IEnumerable<Product> GetProductsByCategoryId(int catgeoryId);
    }
}
