using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practice
{
    class A //: IDisposable
    {
        public A()
        {
            Console.WriteLine("A ctor");
        }
        ~A()
        {
            Console.WriteLine($"A dtor running in {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("A dtor called...");
        }

        //public virtual void Dispose()
        //{
        //    //GC.SuppressFinalize(this);
        //    Console.WriteLine("A dispose called...");
        //}
    }
    class B : A, IDisposable
    {
        public B()
        {
            Console.WriteLine("B ctor");
        }
        ~B()
        {
            Console.WriteLine($"B dtor running in {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("B dtor called...");
        }
        //public override void Dispose()
        public void Dispose()
        {
            //base.Dispose()
            GC.SuppressFinalize(this);
            Console.WriteLine("B dispose called...");
        }
    }
    class C
    {
        ~C()
        {
            Console.WriteLine($"C dtor running in {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("C dtor called...");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Main running in {Thread.CurrentThread.ManagedThreadId}");
            using (B obj = new B())
            {
                Console.WriteLine("end of scope for B");
            }
            C c = new C();
        }
    }
}
