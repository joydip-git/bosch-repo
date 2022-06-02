using System;
using System.ComponentModel;

namespace wpf_DataBinding
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
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
                salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Salary")
                {
                    if (salary < 0)
                    {
                        return "Salary can't be negative";
                    }
                }
                if (columnName == "Name")
                {
                    if (name == string.Empty)
                    {
                        return "Name should  not be empty";
                    }
                }
                return null;
            }
        }
        public string Error => "";

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
/*
        public object this[string propertyName]
        {
            set
            {
                if (propertyName == "Id")
                {
                    id = (int)value;
                }
                if (propertyName == "Name")
                {
                    Name = (string)value;
                }
                if (propertyName == "Salary")
                {
                    Salary = (double)value;
                }
                OnPropertyChanged(propertyName);
            }
        }
        */
