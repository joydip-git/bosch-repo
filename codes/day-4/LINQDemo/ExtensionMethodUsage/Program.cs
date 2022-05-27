using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using EnumerableExtensionLibrary;

namespace ExtensionMethodUsage
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 3, 5, 2, 7, 6, 0, 8, 9 };

            //LINQ: 

            //1. Method syntax (immediate execution)
            numbers
                .OrderByDescending(n => n)
                .Where(n => n % 2 == 0)
                .Take(3)
                .ToList<int>()
                .ForEach(n => Console.WriteLine(n));


            //2. Query operator syntax (delayed/deferred execution)
            var q = from n in numbers
                    orderby n descending
                    where n % 2 == 0
                    select n;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            //immediate execution
            var query = (from n in numbers
                         orderby n descending
                         where n % 2 == 0
                         select n)
                        .Take(3)
                        .ToList<int>();

            //query.Take(3).ToList<int>().ForEach(n => Console.WriteLine(n));
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //Predicate<int> evenDel = delegate(int num) { return num % 2 == 0; }
            //Predicate<int> evenDel = (num) => num % 2 == 0;
            //numbers.Filter<int>(evenDel);
            //var result = numbers.Filter<int>((num) => num % 2 == 0);
            //Func<int, bool> evenDel = (num) => num % 2 == 0;
            //var result = numbers.Where(evenDel);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /*
            //1. sort the array
            numbers.Sort();

            Func<int, int> sortDel = (n) => n;
            IOrderedEnumerable<int> orderedNumbers = numbers.OrderBy(sortDel);

            //2. filter the even numbers
            List<int> evenNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
            }

            Func<int, bool> evenDel = n => n % 2 == 0;
            IEnumerable<int> filteredNumbers = orderedNumbers.Where(evenDel);

            //3. pick up the first 3 even numbers
            List<int> selectedNumebers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                selectedNumebers.Add(evenNumbers[i]);
            }

            IEnumerable<int> selectedValues = filteredNumbers.Take(3);
            //4. print
            //foreach (var item in selectedNumebers)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> finalValues = selectedValues.ToList<int>();

            Action<int> printDel = (n) => Console.WriteLine(n);
            finalValues.ForEach(printDel);
            */

        }
    }
}
