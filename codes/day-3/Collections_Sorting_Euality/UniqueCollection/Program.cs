using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCollection
{
    class Program
    {
        static void Main()
        {
            /*
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(12);
            numbers.Add(1);
            numbers.Add(12);
            numbers.Add(13);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            */
            HashSet<Student> students = new HashSet<Student>();
            Student sunilStudent = new Student(2, "sunil", 67);
            Student joyStudent = new Student(1, "joy", 78);
            Student anilStudent = new Student(2, "sunil", 67);
            //Student anilStudent = sunilStudent;

            students.Add(sunilStudent);
            students.Add(joyStudent);
            students.Add(anilStudent);

            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }

            //sunilStudent==anilStudent
            //sunilStudent.Id==anilStudent.Id
            //sunilStudent.Name==anilStudent.Name
                     

            //if (sunilStudent.GetHashCode() == anilStudent.GetHashCode())
            //    Console.WriteLine("same");
            //else
            //    Console.WriteLine("different");

            ////return sunilStudent==anilStudent?true:false;
            //if (sunilStudent.Equals(anilStudent))
            //    Console.WriteLine("same");
            //else
            //    Console.WriteLine("different");

        }
    }
}
