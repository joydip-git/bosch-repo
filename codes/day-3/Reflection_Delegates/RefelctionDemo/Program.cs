using System;
using System.Reflection;
using System.Configuration;
using System.Diagnostics;

namespace RefelctionDemo
{
    class Program
    {
        static void GetInfo()
        {
            Process process = Process.GetCurrentProcess();
            Console.WriteLine($"{process.ProcessName}, {process.Id}");

            Console.WriteLine("\n");

            AppDomain appDomain = AppDomain.CurrentDomain;
            Console.WriteLine($"{appDomain.FriendlyName}");

            Console.WriteLine("\n");
            Assembly[] allAssemblies = appDomain.GetAssemblies();
            foreach (Assembly assembly in allAssemblies)
            {
                Console.WriteLine($"{assembly.FullName}");
            }
        }
        static void Main()
        {
            string filePath = ConfigurationManager.AppSettings["filePath"];
            Assembly loadedAssembly = Assembly.LoadFrom(filePath);
            Console.WriteLine(loadedAssembly.FullName);

            Console.WriteLine("\n");

            Type[] allTypes = loadedAssembly.GetTypes();

            string clsName = null;
            foreach (Type type in allTypes)
            {
                Console.WriteLine($"Name: {type.FullName}");
                Console.WriteLine($"Class? {type.IsClass}");
                Console.WriteLine($"Interface? {type.IsInterface}");
                Console.WriteLine($"Enum? {type.IsEnum}");
                Console.WriteLine($"Value Type? {type.IsValueType}");
                Console.WriteLine("\n");
                if (type.Name == "Circle")
                {
                    clsName = type.FullName;
                }
            }
            Console.WriteLine("\n");
            Type circleType = loadedAssembly.GetType(clsName);
            //Console.WriteLine(circleType.FullName);
            object obj = Activator.CreateInstance(circleType);

            PropertyInfo radiusPropInfo = circleType.GetProperty("Radius");
            //Console.WriteLine(radiusPropInfo.PropertyType);

            radiusPropInfo.SetValue(obj, 12);
            //Console.WriteLine(radiusPropInfo.GetValue(obj));

            MethodInfo areaMethodInfo = circleType.GetMethod("CalculateArea");
            //Console.WriteLine($"{areaMethodInfo.ReturnType}");

            object result = areaMethodInfo.Invoke(obj, null);
            Console.WriteLine($"Radius: {result}");

            Console.ReadLine();
        }
    }
}
