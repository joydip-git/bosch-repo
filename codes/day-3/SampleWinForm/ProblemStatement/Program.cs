using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement
{
    // delegate bool LogicDel(int num);
    //delegate bool LogicDel<in T>(T arg);
    //delegate TResult LogicDel<in T, out TResult>(T arg);

    //built-in
    //public delegate bool Predicate<in T>(T obj);

    class Logic
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public bool IsPriceGreater(Product p)
        {
            return p.Price > 15000;
        }
    }
    class Program
    {
        //I do not want to change anything in the method logic wise
        //Filter does not want to care about what logic to be applied for filtration
        //Can you somehow pass the logic for filtration (i.e. address of a method) as an argument in this method?
        //static List<int> Filter(List<int> source, MethodInfo methodInfo, object obj)
        //static List<T> Filter<T>(List<T> source, LogicDel<T> logicDel)
        static List<T> Filter<T>(List<T> source, Predicate<T> logicDel)
        //static List<T> Filter<T,TResult>(List<T> source, LogicDel<T,TResult> logicDel)
        {
            List<T> result = new List<T>();

            foreach (T item in source)
            {
                //if((bool) methodInfo.Invoke(obj, new object[] { item }))
                if (logicDel(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 3, 5, 2, 7, 6, 0, 8, 9 };

            //Logic logicObject = new Logic();
            //Type logicType = logicObject.GetType();
            //Type logicType = typeof(Logic);
            //MethodInfo evenInfo = logicType.GetMethod("IsEven);
            // List<int> result = Filter(numbers, evenInfo, logicObject);

            Logic logicObject = new Logic();

            //LogicDel<int> evenDel = new LogicDel<int>(logicObject.IsEven);
            Predicate<int> evenDel = new Predicate<int>(logicObject.IsEven);
            List<int> evenResult = Filter(numbers, evenDel);

            //LogicDel<int> oddDel = new LogicDel<int>(Logic.IsOdd);
            Predicate<int> oddDel = new Predicate<int>(Logic.IsOdd);
            List<int> oddResult = Filter(numbers, oddDel);

            foreach (int item in evenResult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            foreach (int item in oddResult)
            {
                Console.WriteLine(item);
            }


            List<Product> products = new List<Product>
            {
                new Product(1, "dell", 10000),
                new Product(2, "hp", 20000),
                new Product(3, "mac", 30000),
            };

            List<Product> filteredProducts = Filter(products, logicObject.IsPriceGreater);
            foreach (Product item in filteredProducts)
            {
                Console.WriteLine(item);
            }

            //Action action = new Action(Foo);
            //Action<int> action = null;
            // Predicate<int>
            Func<int, int, int> addFn = new Func<int, int, int>(Program.Add);
            Func<int> fooFn = new Func<int>(Program.Foo);
        }
        static int Add(int a, int b) { return a + b; }
        static int Foo() { return 0; }
    }
}
