using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_DataBinding
{
    public class DataWindowPersonViewModel : INotifyPropertyChanged
    {
        private Person person;

        public Person Person
        {
            get { return person; }
            set
            {
                person = value;
                OnPropertyChanged("Person");
            }
        }

        public string ConvertedSalary
        {
            set
            {
                double result;
                if (double.TryParse(value, NumberStyles.Any, null, out result))
                {
                    person.Salary = result;
                }
                else
                {
                    throw new ArgumentException("error");
                }
                OnPropertyChanged("ConvertedSalary");
            }
            get => person.Salary.ToString("C", new CultureInfo("en-US"));
        }

        public string BackColor
        {
            get => person.Salary > 10000 ? "Grey" : "Wheat";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
