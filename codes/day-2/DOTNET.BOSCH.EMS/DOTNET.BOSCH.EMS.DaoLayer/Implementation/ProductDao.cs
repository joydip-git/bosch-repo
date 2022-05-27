using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.DaoLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DOTNET.BOSCH.EMS.DaoLayer.Utilities;
using static DOTNET.BOSCH.EMS.DaoLayer.Utilities.DaoUtility;

namespace DOTNET.BOSCH.EMS.DaoLayer.Implementation
{
    public class ProductDao : IProductDao
    {
        public bool Add(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            string path = GetPath(RecordType.Product);
            List<Product> products = null;
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                products = new List<Product>();                
                while (!reader.EndOfStream)
                {                   
                    string record = null;
                    if ((record = reader.ReadLine()) != string.Empty)
                    {
                        string[] values = record.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        var product = ConvertRecordToProduct(values);
                        products.Add(product);
                    }
                }
                reader.Close();
                reader.Dispose();
            }
            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int catgeoryId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }
    }
}
