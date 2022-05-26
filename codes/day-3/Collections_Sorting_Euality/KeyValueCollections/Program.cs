using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueCollections
{
    class A : IComparable<A>
    {
        int id;
        char keyName;

        public A(int id, char key)
        {
            this.id = id;
            this.keyName = key;
        }

        public int CompareTo(A other)
        {
            return this.id.CompareTo(other.id);
        }
        public override string ToString()
        {
            return this.keyName.ToString();
        }
    }
    class Program
    {
        static void Main()
        {
            /*
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "bosch");
            hashtable.Add('a', 12);
            hashtable.Add("str", 'R');
            //hashtable.Remove('a');
            hashtable['a'] = 98.45;
            //if the key does not exist in the collection, then the key and the value will be added
            hashtable[2] = 67;
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Console.WriteLine("\n\n");

            //keys will be sorted
            //the keys must be of similar type
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "bosch");
            sortedList.Add(0, 12);
            sortedList.Add(2, 'R');
            //sortedList.Remove('a');
            sortedList[2] = 98.45;
            //if the key does not exist in the collection, then the key and the value will be added
            sortedList[6] = 67;
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "bosch");
            dictionary.Add(0, "abcd");
            dictionary.Add(2, "xyz");
            dictionary[0] = "some value";
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }


            SortedList<int, string> sortedGenericList = new SortedList<int, string>();
            sortedGenericList.Add(1, "bosch");
            sortedGenericList.Add(0, "12");
            sortedGenericList.Add(2, "R");
            //sortedList.Remove('a');
            sortedGenericList[2] = "98.45";
            //if the key does not exist in the collection, then the key and the value will be added
            sortedGenericList[6] = "abcd";
            foreach (KeyValuePair<int, string> item in sortedGenericList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            */
            SortedList<A, int> d = new SortedList<A, int>();
            d.Add(new A(2, '2'), 12);
            d.Add(new A(0, '0'), 15);
            d.Add(new A(1, '1'), 13);

            foreach (KeyValuePair<A, int> item in d)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
    }
}
