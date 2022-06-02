using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_DataBinding
{
    public class DataWindowPersonViewModel
    {
        private Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; }
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
            }
            get => person.Salary.ToString("C", new CultureInfo("en-US"));
        }

        public string BackColor
        {
            get => person.Salary > 10000 ? "Grey" : "Wheat";
        }
    }
}
