using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CSharp_OOP.Repository;
using static CSharp_OOP.Repository.EmployeeRepository;

namespace CSharp_OOP.DAO
{
    class EmployeeDao
    {
        public string Add(Employee employee)
        {
            //Employee[] employees = EmployeeRepository.Employees;
            Employee[] employees = Employees;
            bool exists = false;
            foreach (Employee emp in employees)
            {
                if (emp != null)
                {
                    if (emp.Id == employee.Id)
                    {
                        exists = true;
                        break;
                    }
                }
            }
            if (!exists)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] == null)
                    {
                        employees[i] = employee;
                        break;
                    }
                }
                return "Added";
            }
            else
            {
                return "Already exists";
            }
           
        }
        public void Update(Employee employee)
        {

        }

        public Employee[] GetAll()
        {
            //return EmployeeRepository.Employees;
            return Employees;
        }
    }
}
