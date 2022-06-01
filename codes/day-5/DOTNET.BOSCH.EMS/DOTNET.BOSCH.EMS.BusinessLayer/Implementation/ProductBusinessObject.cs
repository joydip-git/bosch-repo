using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.BusinessLayer.Contract;
using DOTNET.BOSCH.EMS.CustomExceptions.BusinessExceptions;
using DOTNET.BOSCH.EMS.CustomExceptions.DaoExceptions;
using DOTNET.BOSCH.EMS.DaoLayer.Contract;
using DOTNET.BOSCH.EMS.DaoLayer.Implementation;
using DOTNET.BOSCH.EMS.IOC;

namespace DOTNET.BOSCH.EMS.BusinessLayer.Implementation
{
    public class ProductBusinessObject : IProductBusinessObject
    {
        private IProductDao productDao;
        public ProductBusinessObject()
        {
            productDao = Factory.Create().Resolve<IProductDao, ProductDao>();
        }
        public Product Fetch()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FetchAll()
        {
            return productDao.GetAll();
        }

        public IEnumerable<Product> FetchProductsByCategoryId(int catgeoryId)
        {
            try
            {
                return productDao.GetAll().Where(p => p.CategoryId == catgeoryId).ToList<Product>();
            }
            catch (DaoException ex)
            {
                throw new BusinessObjectException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new BusinessObjectException(ex.Message, ex);
            }
        }

        public bool Insert(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
