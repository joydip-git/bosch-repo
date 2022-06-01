using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.DaoLayer.Implementation;
using System.Collections.Generic;

namespace DOTNET.BOSCH.EMS.DaoLayer.Tests
{
    [TestClass]
    public class ProductDaoTest
    {
        private ProductDao dao;

        [TestInitialize]
        public void Init()
        {
            dao = new ProductDao();
        }

        [TestCleanup]
        public void Clean()
        {
            dao = null;
        }

        [TestMethod]
        public void GetAllTestPositive()
        {            
            var actualProducts = dao.GetAll() as List<Product>;
            var expectedProducts = new List<Product>
            {
                new Product{ Id=1, Name="Dell XPS", Price=67000.00, Description="new laptop from dell", CategoryId=1 },
                new Product{ Id=2, Name="HP Probook", Price=56000.00, Description="new laptop from HP", CategoryId=2 },
                new Product{ Id=3, Name="Lenovo Thinkpad", Price=78000.00, Description="new laptop from Lenovo", CategoryId=3 },
            };
            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }
    }
}
