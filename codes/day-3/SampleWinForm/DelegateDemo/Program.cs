using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //1. delegate eclaration
    //CalDel is a delegate whicbh can be used to invoke any method(s) whose return type is void and accepts exactly two arguments, both of type int, in ths same order
    delegate void CalDel(int m, int n);
    /*
     class CalDel //: MulticastDelegate:Delegate:Object
     {
         private object _target;
         private MethodInfo _method;
         private Delegate[] _invocationList;

         public CalDel(object target, MethodInfo method)
         {
             _target = target;
             _method = method;
         }

         public object Target { get => _target; }
         public MethodInfo Method { get => _method;  }

         public Delegate[] GetInvocationList(){ return this._invocationList;}

         public void Invoke(int m, int n)
         {
            if(_invocationList.Length==0)
            {
                 _method.Invoke(_target, new object[] { m, n });
            }
            else
            {
                foreach(Delegate d in _invocationList)
                {
                    d.Method.Invoke(_target, new object[]{m,n});
                }
            }
         }
     }
    */

    class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class Program
    {
        static void Main()
        {
            //single-cast delegate
            //2. create an INSTANCE of a delegate
            //pass the address of a method whose signature is same as that of the delegate
            CalDel cdAdd = new CalDel(Calculation.Add);

            //3. invoke the delegate in order to invoke the functionality
            //cdAdd(12, 13);

            Calculation calc = new Calculation();
            CalDel cdSub = new CalDel(calc.Subtract);
            //cdSub.Invoke(12, 3);


            //multi-cast delegate
            CalDel cdMulti = null;
            cdMulti += cdAdd;
            cdMulti += cdSub;

            // cdMulti(12, 3);
            Delegate[] allDels = cdMulti.GetInvocationList();
            foreach (Delegate d in allDels)
            {
                Console.WriteLine($"{d.Method.Name}");
                CalDel cd = d as CalDel;
                cd(12, 3);
            }
        }
    }
}
