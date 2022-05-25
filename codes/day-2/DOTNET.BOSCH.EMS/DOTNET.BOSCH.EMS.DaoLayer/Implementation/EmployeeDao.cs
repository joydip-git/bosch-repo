using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET.BOSCH.EMS.DaoLayer.Contract;
using DOTNET.BOSCH.EMS.BusinessEntities;

namespace DOTNET.BOSCH.EMS.DaoLayer.Implementation
{
    public class EmployeeDao : IDao<Employee>
    {
        public bool Add(Employee data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get()
        {
            throw new NotImplementedException();
        }

        public Employee[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee[] Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee data)
        {
            throw new NotImplementedException();
        }
    }
}
