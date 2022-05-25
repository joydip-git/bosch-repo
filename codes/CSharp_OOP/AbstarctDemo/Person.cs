using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    abstract class Person
    {
        string name;
        //compiler will supply the default ctor if no ctor is written
        //compiler will not supply default ctor if any parameterized ctor is/are written
        //hence if you are writing a parameterized ctor, then explicitly create default ctor too, keeping in mind that this class can act as base class and child class ctor by default invokes base class's default ctor
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }

        public abstract bool IsOutstanding();

        public abstract string Status { get; }
    }
}
