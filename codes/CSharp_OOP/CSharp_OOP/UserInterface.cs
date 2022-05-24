using EmployeeLibrary;
using System;
using CSharp_OOP.DAO;

//static import
using static CSharp_OOP.Utilities.UiUtility;

namespace CSharp_OOP
{
    class UserInterface
    {       
        static void Main()
        {
            //int records = Convert.ToInt32(value);
            int records = GetNumberOfRecordsFromUser();

            EmployeeDao employeeDao = new EmployeeDao();

            for (int index = 0; index < records; index++)
            {
                Employee employeeRef = CreateEmployee();
                Console.WriteLine(employeeDao.Add(employeeRef));
            }

            CalculateSalaryOfEmployees(employeeDao.GetAll());
            Console.WriteLine("\n");
            PrintInformationOfEmployees(employeeDao.GetAll());
        }
    }
}


