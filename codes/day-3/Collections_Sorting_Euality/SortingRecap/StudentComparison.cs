using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRecap
{
    class StudentComparison : IComparer, IComparer<Student>
    {
        int choice;
        public StudentComparison()
        {

        }
        public StudentComparison(int choice)
        {
            this.choice = choice;
        }
        public int Compare(object x, object y)
        {
            return CompareStudents(x as Student, y as Student);
        }

        public int Compare(Student x, Student y)
        {
            return CompareStudents(x, y);
        }
        private int CompareStudents(Student x, Student y)
        {
            //Nullable<int> result = null;
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = x.Id.CompareTo(y.Id);
                    break;

                case 2:
                    result = x.Name.CompareTo(y.Name);
                    break;

                case 3:
                    result = x.Marks.CompareTo(y.Marks);
                    break;

                default:
                    result = x.Id.CompareTo(y.Id);
                    //Console.WriteLine("entered wrong choice...");
                    break;
            }
            //if (result.HasValue)
            //    return result.Value;
            //else
            //    throw new Exception("not possible to compare because of wrong choice");
            return result;
        }
    }
}
