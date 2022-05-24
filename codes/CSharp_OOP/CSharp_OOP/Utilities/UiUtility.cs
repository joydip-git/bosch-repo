using EmployeeLibrary;
using System;

namespace CSharp_OOP.Utilities
{
    //static class instance can't be created
    //it can contain anything static: data member, constructor, property, method and const
    //this type of classes are known as Utility classes
    static class UiUtility
    {
        public static int GetNumberOfRecordsFromUser()
        {
            Console.Write("How many records? ");
            int records = int.Parse(Console.ReadLine());
            return records;
        }

        public static Employee CreateEmployee()
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("\nId: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\nBasic Pay: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("\nDa Pay: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("\nHra Pay: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Employee employee = new Employee(name, id, basic, da, hra);

            return employee;
        }

        public static void CalculateSalaryOfEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                    employee.CalculateSalary();
            }
        }

        public static void PrintInformationOfEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                    Console.WriteLine($"{employee.Name} has salary {employee.TotalSalary}");
            }
        }
    }
}
