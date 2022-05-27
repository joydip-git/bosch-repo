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
            //StudentComparison studentComparison = new StudentComparison(4);
            //students.Sort(studentComparison);

            //3. delegate
            //Comparison<Student> compareStudents = new Comparison<Student>(Program.CompareStudentsById);
            //students.Sort(compareStudents);
            int choice = 3;
            switch (choice)
            {
                case 1:
                    //students.Sort(new Comparison<Student>(Program.CompareStudentsById));
                    students.Sort(
                        delegate (Student x, Student y)
                        {
                            return x.Id.CompareTo(y.Id);
                        }
                    );
                    break;

                case 2:
                    //students.Sort(new Comparison<Student>(Program.CompareStudentsByName));
                    students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
                    break;

                case 3:
                    //students.Sort(new Comparison<Student>(Program.CompareStudentsByMarks));
                    students.Sort((s1, s2) => s1.Marks.CompareTo(s2.Marks));
                    break;

                default:
                    //students.Sort(new Comparison<Student>(Program.CompareStudentsById));
                    students.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));
                    break;
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        static int CompareStudentsById(Student x, Student y)
        {
            return x.Id.CompareTo(y.Id);
        }
        static int CompareStudentsByName(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
        static int CompareStudentsByMarks(Student x, Student y)
        {
            return x.Marks.CompareTo(y.Marks);
        }
    }
}
