using System.Collections.Generic;
using EmployeeModelLibrary.Models;

namespace EmployeeRepositoryLibrary.Repository
{
    public class EmployeeRepository
    {
        public static List<Employee> Employees => new List<Employee>
        {
            new Employee{Id=1, Name="joydip", Salary=2000},
            new Employee{Id=2, Name="anil", Salary=3000},
            new Employee{Id=3, Name="sunil", Salary=1000}
        };
    }
}
