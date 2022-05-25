using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Person
    {
        string name;
        double salary;

        public Person()
        {

        }

        public Person(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public object this[int i]
        {
            set
            {
                if (i == 0)
                    this.name = (string)value;
                if (i == 1)
                    this.salary = (double)value;
            }
            get
            {
                if (i == 0)
                    return this.name;
                if (i == 1)
                    return this.salary;
                else
                    return "NA";
            }
        }

        public object this[string arg]
        {
            set
            {
                if (arg == "name")
                    this.name = (string)value;
                if (arg == "salary")
                    this.salary = (double)value;
            }
            get
            {
                if (arg == "name")
                    return this.name;
                if (arg == "salary")
                    return this.salary;
                else
                    return "NA";
            }
        }
    }
}
