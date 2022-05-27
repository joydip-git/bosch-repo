using EmployeeDaoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary;

namespace DaoExtensionLibrary
{
    public static class DaoExtension
    {
        public static List<Employee> Search(this EmployeeDao empdao, string name)
        {
            return null;
        }
        public static List<Department> Search(this DepartmentDao deptDao, string name)
        {
            return null;
        }
        public static string Foo<T>(this IDao<T> dao, string val)
        {
            return "Welcome " + val;
        }
    }
}
