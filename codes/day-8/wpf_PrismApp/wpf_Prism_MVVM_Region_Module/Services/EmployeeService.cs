using System.Collections.Generic;
using wpf_Prism_MVVM_Region_Module.Models;
using wpf_Prism_MVVM_Region_Module.Repository;

namespace wpf_Prism_MVVM_Region_Module.Services
{
    public class EmployeeService : IEmployeeService
    {

        public List<Employee> GetAll()
        {
            return EmployeeRepository.Employees;
        }
    }
}
