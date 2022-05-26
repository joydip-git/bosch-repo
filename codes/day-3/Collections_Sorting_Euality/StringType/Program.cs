using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        //Param array
        //can be used in method as argument only, to accept N number of arguemnts after any fixed number of argument(s)
        //there can be only ine declaration with params
        //that should be the last argument to accept all remaining parameters
        static string[] Split(string sentence, params char[] separators)
        {
            return null;
        }
        static void Main()
        {
            //params int[] x = new int[4];
            //"I am a freelance consultant, and currently working for Bosch. I am from Bangalore"
            /*
             * word1: count-value
             * word2: count-value
             * ..........................
             * a: 1
             * am: 2
             * and: 1
             * Bangalore:1
             * Bosch: 1
             * consultant: 1
             * currently: 1
             * .........................
             * 
             * 
             */
            Console.Write("enter a sentence: ");
            string value = Console.ReadLine();
            Split(sentence: value, ' ', ',', '.');
        }
    }
}
