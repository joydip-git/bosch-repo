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
using DOTNET.BOSCH.EMS.CustomExceptions.DaoExceptions;

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
            try
            {
                if (File.Exists(path))
                {
                    StreamReader reader = null;
                    using (reader = new StreamReader(path))
                    {
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
                    }
                }
                else
                {
                    throw new FileNotFoundException($"no file found at the given path: {path}");
                }
                return products;
            }
            catch(FileNotFoundException ex)
            {
                throw CreateDaoException(ex.Message, ex);
            }
            catch(IOException ex)
            {
                throw CreateDaoException(ex.Message, ex);
            }
            catch(FormatException ex)
            {
                throw CreateDaoException(ex.Message, ex);
            }
            catch(NullReferenceException ex)
            {
                throw CreateDaoException(ex.Message, ex);
            }
            catch(Exception ex)
            {
                throw CreateDaoException(ex.Message, ex);
            }
        }

        public IEnumerable<Product> GetProductsByCategoryId(int catgeoryId)
        {
            return null;
        }

        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }
    }
}
