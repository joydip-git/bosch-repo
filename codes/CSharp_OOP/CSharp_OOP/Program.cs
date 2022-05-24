using EmployeeLibrary;
using System;

namespace CSharp_OOP
{
    class Program
    {
        static void Main()
        {
            //Employee employeeObj = new Employee("Joydip", 1, 1000, 2000, 3000);
            //C# 4.0 (2010) -- named arguments
            Employee joydipEmployeeObj = new Employee(id: 1, basicPay: 1000, name: "joydip", daPay: 2000, hraPay: 3000);

            Employee anilEmployeeObj = new Employee(id: 2, basicPay: 2000, name: "Anil", daPay: 3000, hraPay: 4000);

            //joydipEmployeeObj.SetProjectName("CITA");
            //anilEmployeeObj.SetProjectName("SSIS");

            joydipEmployeeObj.ProjectName = "CITA";
            anilEmployeeObj.ProjectName = "SSIS";

            Console.WriteLine(joydipEmployeeObj.ProjectName);

            int x = 10;
            Console.WriteLine(x);
        }
    }
}
