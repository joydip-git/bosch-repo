using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    class Student : Person
    {
        double marks;
        public Student()
        {

        }
        public Student(string name, double marks) : base(name)
        {
            this.marks = marks;
        }

        public double Marks { get => marks; set => marks = value; }

        public override bool IsOutstanding()
        {
            return this.marks >= 85 ? true : false;
        }

        public override string Status => IsOutstanding() ? $"{Name} is outstanding Student" : $"{Name} is not an outstanding Student";
    }
}
