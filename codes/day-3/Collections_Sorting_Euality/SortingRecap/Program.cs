using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRecap
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(2,"sunil",67),
                new Student(1,"joy",78),
                new Student(3, "anil",70)
            };
            //1.
            //students.Sort();

            //2.
            StudentComparison studentComparison = new StudentComparison(4);
            students.Sort(studentComparison);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
