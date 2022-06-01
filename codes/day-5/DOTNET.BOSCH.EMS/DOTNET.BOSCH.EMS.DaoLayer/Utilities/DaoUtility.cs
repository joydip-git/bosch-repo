using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.CustomExceptions.DaoExceptions;

namespace DOTNET.BOSCH.EMS.DaoLayer.Utilities
{
    static class DaoUtility
    {
        public static string GetPath(RecordType recordType)
        {
            string filePath = null;
            switch (recordType)
            {
                case RecordType.Product:
                    filePath = ConfigurationManager.AppSettings["productsFilePath"];
                    break;

                case RecordType.Category:
                    filePath = ConfigurationManager.AppSettings["categoriesFilePath"];
                    break;

                default:
                    break;
            }
            return filePath;
        }

        public static Product ConvertRecordToProduct(string[] record)
        {
            Product product = new Product
            {
                Id = int.Parse(record[0]),
                Name = record[1],
                Price = double.Parse(record[2]),
                Description = record[3],
                CategoryId = int.Parse(record[4])
            };
            return product;
        }

        public static Category ConvertRecordToCategory(string[] record)
        {
            Category category = new Category
            {
                Id = int.Parse(record[0]),
                Name = record[1]
            };
            return category;
        }

        public static DaoException CreateDaoException(string message, Exception ex = null)
        {
            return new DaoException(message, ex);
        }
    }
}
