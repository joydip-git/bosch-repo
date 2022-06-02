using System;
using System.Collections.Generic;
//using System.Collections.Specialized;
using System.ComponentModel;

namespace EventDemo
{
    class RecordableCollection<T> //: INotifyCollectionChanged<T>
    {
        List<T> items;
        public RecordableCollection()
        {
            items = new List<T>();
        }
        public void Add(T arg)
        {
            items.Add(arg);
        }
        public void PersonProprtyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Console.WriteLine(e.PropertyName);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            RecordableCollection<Person> recordableCollection = new RecordableCollection<Person>();

            PropertyChangedEventHandler ev = new PropertyChangedEventHandler(recordableCollection.PersonProprtyChanged);
            p.PropertyChanged += ev;

            p.Id = 1;
            p.Name = "anil";
            p.Salary = 1000;


            //p.OnPropertyChanged(null, new string[] { "Id", "Name", "Salary" });
            //p.OnPropertyChanged();


        }

    }
}
