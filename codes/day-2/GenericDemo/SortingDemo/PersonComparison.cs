using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo
{
    class PersonComparison : IComparer, IComparer<Person>
    {
        int choice;
        public PersonComparison()
        {

        }
        public PersonComparison(int choice)
        {
            this.choice = choice;
        }
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int Compare(Person x, Person y)
        {
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
                    result = x.Salary.CompareTo(y.Salary);
                    break;

                default:
                    result = x.Id.CompareTo(y.Id);
                    break;
            }
            return result;
        }
    }
}
