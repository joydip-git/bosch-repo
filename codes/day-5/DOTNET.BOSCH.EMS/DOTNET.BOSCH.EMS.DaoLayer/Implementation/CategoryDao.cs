using DOTNET.BOSCH.EMS.BusinessEntities;
using DOTNET.BOSCH.EMS.DaoLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.BOSCH.EMS.DaoLayer.Utilities;
using static DOTNET.BOSCH.EMS.DaoLayer.Utilities.DaoUtility;
using System.IO;

namespace DOTNET.BOSCH.EMS.DaoLayer.Implementation
{
    public class CategoryDao : IDao<Category>
    {
        public bool Add(Category data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            string path = GetPath(RecordType.Category);
            List<Category> categories = null;
            StreamReader reader = null;
            if (File.Exists(path))
            {
                using (reader = new StreamReader(path))
                {
                    categories = new List<Category>();
                    while (!reader.EndOfStream)
                    {
                        string record = null;
                        if ((record = reader.ReadLine()) != string.Empty)
                        {
                            string[] values = record.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            var category = ConvertRecordToCategory(values);
                            categories.Add(category);
                        }
                    }
                    reader.Close();
                }
            }
            return categories;
        }

        public bool Update(Category data)
        {
            throw new NotImplementedException();
        }
    }
}
