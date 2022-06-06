using EmployeeModelLibrary.Models;
using System.Collections.Generic;

namespace EmployeeServiceLibrary.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }
}
