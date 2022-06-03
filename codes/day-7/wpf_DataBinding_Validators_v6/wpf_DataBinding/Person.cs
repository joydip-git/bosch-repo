using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace wpf_DataBinding
{
    public class Person : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private int id;
        private string name;
        private double salary;
        private Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

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
                if (salary < 0)
                {
                    SetErrors("Salary", new List<string> { "salary can't be negative" });
                }
                else
                {
                    ClearErrors("Salary");
                }
                OnPropertyChanged("Salary");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if(name.Length<4 || name.Length > 10)
                {
                    SetErrors("Name", new List<string> { "length should be between 4 and 10" });
                }
                else
                {
                    ClearErrors("Name");
                }
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool HasErrors => errors.Count > 0;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return errors.Values;
            }
            else
            {
                if (errors.ContainsKey(propertyName))
                {
                    return errors[propertyName];
                }
                else
                {
                    return null;
                }
            }
        }
        private void SetErrors(string propertyName, List<string> propertyErrors)
        {
            errors.Remove(propertyName);
            errors.Add(propertyName, propertyErrors);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

        }
        private void ClearErrors(string propertyName)
        {
            errors.Remove(propertyName);
            if (ErrorsChanged != null)
            {
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
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
