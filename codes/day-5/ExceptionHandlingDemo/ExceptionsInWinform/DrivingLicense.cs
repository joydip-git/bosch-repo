using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsInWinform
{
    public class DrivingLicense
    {
        private int age;
        private string name;

        public DrivingLicense()
        {

        }
        public DrivingLicense(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    AgeLessThan18Exception ex = new AgeLessThan18Exception("age for DL should be equal to or more than 18");
                    throw ex;
                }
                else
                {
                    age = value;
                }
            }
        }

    }
}
