using EmployeeModelLibrary.Models;
using EmployeeRepositoryLibrary.Repository;
using System.Collections.Generic;

namespace EmployeeServiceLibrary.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAll()
        {
            return EmployeeRepository.Employees;
        }
    }
}
