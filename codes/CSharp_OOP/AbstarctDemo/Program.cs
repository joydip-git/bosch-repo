using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[4];
            people[0] = new Professor("anil", 8);
            people[1] = new Professor("mahesh", 3);
            people[2] = new Student("sunil", 78);
            people[3] = new Student("suresh", 87);
            foreach (Person person in people)
            {
                Console.WriteLine(person.Status);
            }
        }
    }
}
