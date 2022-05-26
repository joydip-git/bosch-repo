using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp
{
    class MyButton
    {
        private string name;
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public event ? Click;
    }
}
