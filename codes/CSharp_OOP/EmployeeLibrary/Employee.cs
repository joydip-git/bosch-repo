using System;

namespace EmployeeLibrary
{
    public class Employee //:object
    {
        public string name;
        readonly int id;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        static decimal joiningBonus;
        string projectName;
        decimal totalSalary;

        static Employee()
        {
            joiningBonus = 10000;
        }

        public Employee()
        {
        }

        public Employee(string name, int id, decimal basicPay, decimal daPay, decimal hraPay, string project = null)
        {
            this.name = name;
            this.id = id;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
            this.projectName = project;
        }

        public int Id => this.id;
        public decimal TotalSalary => this.totalSalary;
        public string Name { get => name; set => name = value; }
        public decimal DaPay { get => daPay; set => daPay = value; }
        public decimal HraPay { get => hraPay; set => hraPay = value; }
        public static decimal JoiningBonus { get => joiningBonus; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public decimal BasicPay { get => basicPay; set => basicPay = value; }

        public void CalculateSalary()
        {
            this.totalSalary = this.basicPay + daPay + hraPay + joiningBonus;
        }

        public void Foo() { }
    }
}
