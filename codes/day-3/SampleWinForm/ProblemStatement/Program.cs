using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement
{
    class Logic
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
    class Program
    {    
        //I do not want to change anything in the method logic wise
        //Filter does not want to care about what logic to be applied for filtration
        //Can you somehow pass the logic for filtration as an argument in this method?
        static List<int> Filter(List<int> source)
        {
            List<int> result = new List<int>();
            Logic logic = new Logic();
            foreach (int item in source)
            {
                if (logic.IsOdd(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 3, 5, 2, 7, 6, 0, 8, 9 };
            List<int> result = Filter(numbers);

        }
    }
}
