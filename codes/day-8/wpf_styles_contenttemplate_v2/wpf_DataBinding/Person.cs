using System;
using System.ComponentModel;

namespace wpf_DataBinding
{
    public class Person : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private double salary;

        public Person()
        {

        }

        public Person(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("price can not be negative");
                }
                else
                {
                    salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                //if (value == string.Empty)
                //{

                //}
                //else if (value.Length < 6)
                //{

                //}
                //else
                //{
                name = value;
                OnPropertyChanged("Name");
                //}
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
