using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCollection
{
    class Student : IComparable, IComparable<Student>
    {
        private int id;
        private string name;
        private double marks;

        public Student()
        {

        }

        public Student(int id, string name, double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;
            if (this.id.CompareTo(other.id) == 0)
                if (this.name.CompareTo(other.name) == 0)
                    return this.marks.CompareTo(other.marks);
                else
                    return this.name.CompareTo(other.name);
            else
                return this.id.CompareTo(other.id);
        }

        public int CompareTo(Student other)
        {
            if (this.id.CompareTo(other.id) == 0)
                if (this.name.CompareTo(other.name) == 0)
                    return this.marks.CompareTo(other.marks);
                else
                    return this.name.CompareTo(other.name);
            else
                return this.id.CompareTo(other.id);
        }

        public override string ToString()
        {
            return $"{this.id}, {this.name}, {this.marks}";
            //return $"{this.GetType().FullName}";
        }
        public override int GetHashCode()
        {
            //return this.GethashCode();
            const int seedValue = 23;
            int hash = 0;
            hash = this.id.GetHashCode() * seedValue;
            hash = this.name == null || this.name == string.Empty ? hash * seedValue : this.name.GetHashCode() * hash;
            hash = this.marks.GetHashCode() * hash;
            return hash;
        }
        public override bool Equals(object obj)
        {
            //return this == obj;
            if (obj ==null)
            {
                throw new ArgumentNullException("argument is null");
            }
            if (!(obj is Student))
                throw new ArgumentException("argument os not of type Student");

            Student other = obj as Student;

            if (this == other)
                return true;

            if (!this.id.Equals(other.id))
                return false;

            if (!this.name.Equals(other.name))
                return false;

            if (!this.marks.Equals(other.marks))
                return false;

            return true;

        }
        public bool Equals(Student other)
        {
            //return this == obj;
            if (other == null)
            {
                throw new ArgumentNullException("argument is null");
            }         

            if (this == other)
                return true;

            if (!this.id.Equals(other.id))
                return false;

            if (!this.name.Equals(other.name))
                return false;

            if (!this.marks.Equals(other.marks))
                return false;

            return true;
        }
    }
}
