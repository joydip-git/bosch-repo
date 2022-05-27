using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
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
}
