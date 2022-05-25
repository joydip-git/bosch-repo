using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    class Person : IComparable, IComparable<Person>
    {
        string name;
        double salary;
        int id;

        public Person()
        {

        }
        public Person(string name, double salary, int id)
        {
            this.name = name;
            this.salary = salary;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }

        public static bool operator >(Person p1, Person p2)
        {
            return false;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return false;
        }

        //internalization of sorting
        //non-generic IComparable
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("the argument is null");

            if (!(obj is Person))
                throw new ArgumentException("argument is not of type Person");

            Person other = obj as Person;

            if (this == other)
                return 0;

            if (this.id.CompareTo(other.id) == 0)
                if (this.name.CompareTo(other.name) == 0)
                    return this.salary.CompareTo(other.salary);
                else
                    return this.name.CompareTo(other.name);
            else
                return this.id.CompareTo(other.id);
        }

        //generic IComparable<T>
        public int CompareTo(Person other)
        {
            if (other == null)
                throw new NullReferenceException("the argument is null");

            if (this == other)
                return 0;

            if (this.id.CompareTo(other.id) == 0)
                if (this.name.CompareTo(other.name) == 0)
                    return this.salary.CompareTo(other.salary);
                else
                    return this.name.CompareTo(other.name);
            else
                return this.id.CompareTo(other.id);
        }
    }
}
