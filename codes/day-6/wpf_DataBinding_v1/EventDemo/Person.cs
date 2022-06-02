using System.ComponentModel;

namespace EventDemo
{
    public class CustomPropertyChangedEventArgs : PropertyChangedEventArgs
    {
        private string[] properties;

        public string[] Properties => properties;

        public CustomPropertyChangedEventArgs(string propertyName, string[] properties = null) : base(propertyName)
        {
            this.properties = properties;
        }
    }



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

        public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName, string[] properties = null)
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                //PropertyChanged(this, new CustomPropertyChangedEventArgs(propertyName, properties));
            }
        }
    }
}
