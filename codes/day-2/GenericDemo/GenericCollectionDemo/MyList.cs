using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class MyList<T> : IEnumerable<T>
    {
        T[] items;
        int index;
        public MyList()
        {
            items = new T[4];
        }
        public void Add(T item)
        {
            if (index == items.Length)
            {
                T[] temp = new T[items.Length * 2];
                items.CopyTo(temp, 0);
                items = temp;
            }
            items[index] = item;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int temp = this.Count;
            Console.WriteLine(temp);
            for (int i = 0; i < this.Count; i++)
            {
                if (temp != this.Count)
                    throw new Exception("collection should not be modified");

                yield return items[i];
            }
            //yield return items[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => index;

        public int Capacity => items.Length;

        public T this[int i]
        {
            set => items[i] = value;
            get => (T)items[i];
        }
    }
}
