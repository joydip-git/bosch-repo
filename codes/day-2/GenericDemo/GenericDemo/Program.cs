using System;

namespace GenericDemo
{
    interface ICusom<T> //where T : class, new()
    {
        void Foo(T a);
    }
    class Custom<T> : ICusom<T> where T : class, new()
    {
        public void Foo(T arg)
        {

        }
        public void Foo(int x) { }
    }
    class Program
    {
        //generic method with constraint
        static void Add<T>(T a, T b) where T : struct
        {

        }
        static void Add<T1, T2>(T1 a, T2 b) where T1 : struct where T2 : class
        {

        }
        static void Main()
        {
            Add<int>(12, 13);
            Add<int, string>(12, "");
            //new Custom<int>().Foo(12);
        }
    }
}
