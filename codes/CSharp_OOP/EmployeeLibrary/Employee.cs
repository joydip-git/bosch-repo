using System;

namespace EmployeeLibrary
{
    public class Employee
    {
        string name;
        readonly int id;
        //static readonly int x;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        // public const decimal joiningBonus = 10000; //fixed value for every instance of Emploeyee
        //static decimal joiningBonus = 10000; //field initialization
        static decimal joiningBonus;
        string projectName;
        decimal totalSalary;

        //static ctor: DO NOT USE ANY ACCESS SPECIFIER, not even public or private
        //used to assign value to static data members
        //only one time this ctor is invoked, the very first time you create an instance
        //you can't call this ctor explicitly and hence, there is no chance of overloading the static ctor
        static Employee()
        {
            // x = 100;
            joiningBonus = 10000;
            // Console.WriteLine("static ctor, bonus: {0}", joiningBonus);
            //Console.WriteLine("static ctor, bonus: " + joiningBonus);

            //string interpolation (C# 6.0 - 2013-15)
            Console.WriteLine($"static ctor, bonus: {joiningBonus}");
        }

        public Employee()
        {
        }

        //c# 4.0 -2010 (optional argument with default value)
        public Employee(string name, int id, decimal basicPay, decimal daPay, decimal hraPay, string project = null)
        {
            Console.WriteLine("regular ctor called");
            this.name = name;
            this.id = id;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
            this.projectName = project;
        }

        //public int GetId()
        //{
        //    return this.id;
        //}

        //read-only property
        //public int Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }
        //}
        public int Id
        {
            get => this.id;
        }
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //property
        public string ProjectName
        {
            // public void SetProjectName(string project)
            set
            {
                this.projectName = value;
            }
            //public string GetProjectName()
            get
            {
                return this.projectName;
            }
        }

        public decimal BasicPay
        {
            set => this.basicPay = value;
            get => this.basicPay;
        }

        //public decimal GetTotalSalary()
        //{
        //    return this.totalSalary;
        //}

        //oldest 1.
        //public decimal TotalSalary
        //{
        //    get { return this.totalSalary; }
        //}

        //2.
        //public decimal TotalSalary
        //{
        //    get => this.totalSalary;
        //}

        //3. only for readonly properties
        public decimal TotalSalary => this.totalSalary;

        public string Name { get => name; set => name = value; }
        public decimal DaPay { get => daPay; set => daPay = value; }
        public decimal HraPay { get => hraPay; set => hraPay = value; }
        public static decimal JoiningBonus { get => joiningBonus; }


        //methods
        public void CalculateSalary()
        {
            this.totalSalary = this.basicPay + daPay + hraPay + joiningBonus;
        }
    }
}
