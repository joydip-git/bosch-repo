using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionsInWinform
{
    public partial class ApplicationForm : Form
    {
        private List<DrivingLicense> appFormData = new List<DrivingLicense>();
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DrivingLicense formData = new DrivingLicense
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text)
                };
                appFormData.Add(formData);
            }
            catch (AgeLessThan18Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }        
    }
}
