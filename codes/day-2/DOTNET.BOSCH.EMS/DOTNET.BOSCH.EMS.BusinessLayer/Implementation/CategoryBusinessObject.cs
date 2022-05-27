using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.BusinessLayer.Contract;
using DOTNET.BOSCH.EMS.DaoLayer.Contract;
using DOTNET.BOSCH.EMS.DaoLayer.Implementation;
using DOTNET.BOSCH.EMS.IOC;

namespace DOTNET.BOSCH.EMS.BusinessLayer.Implementation
{
    public class CategoryBusinessObject : IBusinessObject<Category>
    {
        private IDao<Category> categoryDao;

        public CategoryBusinessObject()
        {
            categoryDao = Factory.Create().Resolve<IDao<Category>, CategoryDao>();
        }
        public Category Fetch()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FetchAll()
        {
            return categoryDao.GetAll();
        }

        public bool Insert(Category data)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Category data)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
