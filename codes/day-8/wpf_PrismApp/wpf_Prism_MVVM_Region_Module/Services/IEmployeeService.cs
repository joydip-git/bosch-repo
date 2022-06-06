using System.Collections.Generic;
using wpf_Prism_MVVM_Region_Module.Models;

namespace wpf_Prism_MVVM_Region_Module.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }
}
