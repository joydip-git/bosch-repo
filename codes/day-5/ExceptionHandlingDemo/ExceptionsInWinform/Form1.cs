using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationLibray;

namespace ExceptionsInWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculation calc = null;
            int? result = null;
            try
            {
                int first = int.Parse(txtFirst.Text);
                int second = int.Parse(txtSecond.Text);
                calc = new Calculation();
                result = calc.Divide(first, second);
                if (richTxtErrors.Visible == true)
                {
                    richTxtErrors.Clear();
                    richTxtErrors.Visible = false;
                }                
            }
            catch (FormatException ex)
            {
                //MessageBox.Show(ex.ToString());
                ShowErrors(ex);
            }
            catch (DivideByZeroException ex)
            {
                //MessageBox.Show(ex.ToString());
                ShowErrors(ex);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                ShowErrors(ex);
            }
            finally
            {
                if (result.HasValue)
                {
                    MessageBox.Show(result.ToString());
                }
                else
                {
                    MessageBox.Show("could not calculate due to error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTxtErrors.Visible = false;
        }
        private void ShowErrors(Exception ex)
        {
            if (richTxtErrors.Visible == false)
                richTxtErrors.Visible = true;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(ex.Message + Environment.NewLine);
            stringBuilder.Append(ex.TargetSite.ToString() + Environment.NewLine);
            stringBuilder.Append(ex.Source + Environment.NewLine);
            stringBuilder.Append(ex.StackTrace + Environment.NewLine);
            richTxtErrors.Text = stringBuilder.ToString();
        }
    }
}
