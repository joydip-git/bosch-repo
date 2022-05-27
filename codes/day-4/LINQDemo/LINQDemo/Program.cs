using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    delegate bool LogicDel<in T>(T arg);
    class Program
    {
        static List<T> Filter<T>(List<T> source, LogicDel<T> logicDel)
        {
            List<T> result = new List<T>();

            foreach (T item in source)
            {
                if (logicDel(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 3, 5, 2, 7, 6, 0, 8, 9 };
            //LogicDel<int> evenDel = new LogicDel<int>(new Logic().IsEven);
            //List<int> result = Filter(numbers, evenDel);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // public bool IsGreaterThan
            //anonymous method
            //int criteria = 5; //using outer parameter in anonymus method
            //LogicDel<int> greterThanDel = delegate (int num)
            //{
            //    return num > criteria;
            //};
            //List<int> res = Filter(numbers, greterThanDel);
            //foreach (int item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Lambda expression to write anonymous method
            //LogicDel<int> lesserThanDel = (num) => num < criteria;

            Action<int> printDel = (val) => Console.WriteLine(val);

            Func<int, int, int> addDel = delegate (int a, int b)
               {
                   return a + b;
               };
            Func<int, int, int> subDel = (a, b) => a - b;
            Console.WriteLine(subDel(12, 3));

            List<Product> products = new List<Product>
            {
                new Product(1, "dell", 10000),
                new Product(2, "hp", 20000),
                new Product(3, "mac", 30000),
            };

            //1.
            //List<Product> filteredProducts = Filter(products, new LogicDel<Product>(new Logic().IsPriceGreater));

            //2. anonymous method
            //LogicDel<Product> filterProductDel = delegate (Product p)
            //{
            //    return p.Price > 15000;
            //};

            //3. anonymous method with lambda expression
            //LogicDel<Product> filterProductDel = (p) => p.Price > 15000;
            //List<Product> filteredProducts = Filter(products, filterProductDel);

            //4.            
            List<Product> filteredProducts = Filter(products, p => p.Price > 15000);
            foreach (Product item in filteredProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
