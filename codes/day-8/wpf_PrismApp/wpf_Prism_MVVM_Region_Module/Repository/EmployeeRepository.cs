using System.Collections.Generic;
using wpf_Prism_MVVM_Region_Module.Models;

namespace wpf_Prism_MVVM_Region_Module.Repository
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
