using System;

namespace wpf_DataBinding.Models
{
    public class Person 
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
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
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
