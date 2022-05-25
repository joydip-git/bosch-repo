using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        public static void Print()
        {
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
        }

        public static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }

        public static IShape CreateShape(int choice)
        {
            IShape shape = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case 2:
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Base: ");
                    double tbase = double.Parse(Console.ReadLine());
                    shape = new Triangle(tHeight: height, tBase: tbase);
                    break;

                default:
                    Console.WriteLine("\nenter a proper choice");
                    break;
            }

            return shape;
        }

        static void Main()
        {
            Print();
            IShape shape = CreateShape(GetChoice());
            Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");
        }
    }
}
