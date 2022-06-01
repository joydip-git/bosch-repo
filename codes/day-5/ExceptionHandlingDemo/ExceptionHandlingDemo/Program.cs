using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static int Divide(int a, int b)
        {
            try
            {
                int res = a / b;
                return res;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
        static void Main()
        {            
            try
            {
                int a = 10;
                int b = 0;
                int result = Divide(a, b);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"App: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"App: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }            
        }
    }
}
