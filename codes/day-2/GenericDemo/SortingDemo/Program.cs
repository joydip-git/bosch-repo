using System;
using System.Collections.Generic;

namespace SortingDemo
{
    class Program
    {
        static void SortNumber()
        {
            //C# 3.0 (collection initializer)
            List<int> numbers = new List<int> { 1, 3, 2, 5, 6, 4, 7, 9, 8, 0 };
            //numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    //if (numbers[i] > numbers[j])
                    if (numbers[i].CompareTo(numbers[j]) > 0)
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person("joy",3000,1),
                new Person("anil",2000,3),
                new Person("sunil",1000,2)
            };
            //this version expects the Person class must implement IComparable/IComparable<T>
            //people.Sort();

            people.Sort(new PersonComparison(2));

            //for (int i = 0; i < people.Count; i++)
            //{
            //    for (int j = i + 1; j < people.Count; j++)
            //    {
            //        if (people[i].CompareTo(people[j]) > 0)
            //        {
            //            Person temp = people[i];
            //            people[i] = people[j];
            //            people[j] = temp;
            //        }
            //    }
            //}
            foreach (Person item in people)
            {
                Console.WriteLine($"{item.Name}, {item.Id}, {item.Salary}");
            }
        }
    }
}
