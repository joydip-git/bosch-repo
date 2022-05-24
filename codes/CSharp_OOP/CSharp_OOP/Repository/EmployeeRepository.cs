using EmployeeLibrary;

namespace CSharp_OOP.Repository
{
    static class EmployeeRepository
    {
        static Employee[] employees;

        static EmployeeRepository()
        {
            employees = new Employee[10];
        }

        public static Employee[] Employees => employees;
    }
}
