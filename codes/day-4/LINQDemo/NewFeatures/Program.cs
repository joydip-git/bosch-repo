using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures
{
    class Person
    {
        readonly int x;
        //string name;
        //int id;

        //string _NameField;
        //int _IdField;

        public Person()
        {
            x = 10;
        }
        //public Person(int id)
        //{
        //    this.id = id;
        //}
        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        //public string Name { get => nameField; set => nameField= value; }
        //public int Id { get => id; set => id = value; }

        //automatic or auto-implemented properties
        public string Name { get; set; }
        public int Id { get; set; }
    }
    class Employee
    {
        int id;
        public Employee(int id, string name, double basic, double da)
        {
            Id = id;
            Name = name;
            Basic = basic;
            Da = da;
        }

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    id = value;
                }
            }
        }
        public string Name { get; set; }
        public double Basic { get; set; }
        public double Da { get; set; }
        public double Salary { get; protected set; }

        public void Calculate()
        {
            Salary = Basic + Da;
        }

    }
    class Program
    {
        static object Get()
        {
            //anoymous type (readonly object)
            var maniPerson = new { FirstName = "Manikandan", LastName = "C" };
            return maniPerson;
        }
        static void Main()
        {
            //value must be assigned to implicitly typed variable (x)
            var x = 10;

            //strongly typed (z)
            int z = 10;


            //int[] arr = new int[2];
            //implicitly typed array
            var arr1 = new[] { 1, 2, 3 };
            var arr = new object[] { 1, 3, "", 'a', 12.34 };

            //Person joy = new Person();
            //joy.Name = "joy";
            //joy.Id = 1;

            //object initializer
            Person anilPerson = new Person { Id = 1 };
            anilPerson.Name = "anil";
            Person sunulPerson = new Person { Name = "sunil", Id = 2 };
            //collection initializer
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name="anil" },
                new Person { Name = "sunil", Id = 2 }
            };

            //Console.WriteLine(Get() as ?);

        }
    }
}
