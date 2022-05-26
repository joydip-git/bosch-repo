using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    partial class MyForm : Form
    {
        public MyForm()
        {
            Init();
        }
        //how do I get this function called when the button's click is invoked
        private void Called(object sender, EventArgs e)
        {
            MessageBox.Show("called");
        }
        private void CalledAgain(object sender, EventArgs e)
        {
            MessageBox.Show("called again");
        }
    }
}
