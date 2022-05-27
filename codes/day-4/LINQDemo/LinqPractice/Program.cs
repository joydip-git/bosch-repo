using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Result
    {
        public char Key { get; set; }
        public List<string> Places { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<string> places = new List<string> { "Chennai", "Mumbai", "Bangalore", "Madurai", "Coimbatore", "Baroda" };
            /*
             * Places with B
             * ----------------------
             * Bangalore
             * Baroda
             * 
             * Places with C
             * -----------------------
             */

            //List<Result> results = new List<Result>();
            /*
           SortedList<char, List<string>> results = new SortedList<char, List<string>>();

           foreach (var item in places)
           {
               if (!results.ContainsKey(item[0]))
               {
                   results.Add(item[0], new List<string> { item });
               }
               else
               {
                   results[item[0]].Add(item);
                   results[item[0]].Sort();
               }
           }
           foreach (KeyValuePair<char,List<string>> item in results)
           {
               Console.WriteLine($"Places starting with {item.Key}");
               Console.WriteLine("---------------------------------");
               foreach (var place in item.Value)
               {
                   Console.WriteLine(place);
               }
               Console.WriteLine("\n");
           }
           */

            //LINQ: Grouping
            //IEnumerable<IGrouping<char, string>> groups =
            //    from place in places
            //    orderby place ascending
            //    group place by place[0];

            //IEnumerable<IGrouping<char,string>>

            IEnumerable<IGrouping<char, string>> groups =
                places
                .OrderBy(place => place)
                .GroupBy(place => place[0]);

            foreach (var g in groups)
            {
                Console.WriteLine($"Places starting with {g.Key}");
                Console.WriteLine("---------------------------------");
                foreach (var place in g)
                {
                    Console.WriteLine(place);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
