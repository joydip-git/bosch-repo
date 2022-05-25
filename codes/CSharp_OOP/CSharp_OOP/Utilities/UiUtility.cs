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

        public static Employee CreateEmployee(int choice)
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic Pay: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            Console.Write("Project Name: ");
            string project = Console.ReadLine();

            Employee employee = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Incentive Pay: ");
                    decimal incentive = decimal.Parse(Console.ReadLine());
                    employee = new Developer(name, id, basic, da, hra, incentive, project);
                    break;

                case 2:
                    Console.Write("Gratuity Pay: ");
                    decimal gratuity = decimal.Parse(Console.ReadLine());
                    employee = new Hr(name, id, basic, da, hra, gratuity, project);
                    break;

                default:
                    Console.WriteLine("\nenter a proper choice");
                    break;
            }

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

        public static void Print()
        {
            Console.WriteLine("\n 1. Developer");
            Console.WriteLine("2. Hr");
        }

        public static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }

    }
}
