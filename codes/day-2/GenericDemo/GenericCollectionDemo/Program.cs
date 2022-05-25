using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Program
    {
        static void ArrayListDemo()
        {
            //boxing
            int x = 10;
            object obj = x;
            //unboxing
            int y = (int)obj;

            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add("bosch");
            al.Add(null);
            al.Add(12.34);
            al.Add('a');
            //<=number or elements already present
            al.Insert(1, 123);
            //al.Remove(12);
            //al.RemoveAt(3);
            //al.AddRange(new object[] { 11, "bangalore" });
            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }

            IEnumerator ie = al.GetEnumerator();
            while (ie.MoveNext())
            {
                //al[1] = 3333;
                if (ie.Current == null)
                    Console.WriteLine("NA");
                Console.WriteLine(ie.Current);
            }
        }
        static void ListDemo()
        {
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(123);
            numbers.Add(123);
            numbers.Add(123);
            Console.WriteLine($"Present element count: {numbers.Count}");
            Console.WriteLine($"Actual Capacity: {numbers.Capacity}");
            Console.WriteLine(numbers[2]);
        }
        static void Main()
        {
            //ListDemo();

            //Person anilPerson = new Person();
            //anilPerson[0] = "Anil";
            //anilPerson[1] = 1000;

            //Person sunilPerson = new Person();
            //sunilPerson["name"] = "Sunil";
            //sunilPerson["salary"] = 2000;

            MyList<int> numbers = new MyList<int>();

            numbers.Add(12);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(11);
            numbers.Add(22);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"value at numbers[{i}]: {numbers[i]}");
            }
            foreach (int item in numbers)
            {
                //numbers.Add(1222);
                Console.WriteLine($"Value:{item}");
            }

            IEnumerator<int> ieNumbers = numbers.GetEnumerator();
            while (ieNumbers.MoveNext())
            {
                Console.WriteLine($"value: {ieNumbers.Current}");
            }
        }
    }
}
