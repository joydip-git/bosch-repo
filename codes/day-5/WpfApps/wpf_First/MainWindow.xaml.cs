using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_First
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Binding object
            //Binding b = new Binding(); {Binding}
            //source configuration
            //b.ElementName = "slider1"; {Binding ElementName=slider1}
            //b.Path = new PropertyPath("Value"); {Binding ElementName=slider1, Path=Value}
            //b.Mode = BindingMode.OneWay;
            //b.UpdateSourceTrigger = UpdateSourceTrigger.Default;
            //{Binding ElementName=slider1, Path=Value, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}
            //target configuration
            //txtSliderValue.SetBinding(TextBox.TextProperty, b);
        }

        /*
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                //MessageBox.Show(e.NewValue.ToString());
                //foreach (var item in grid1.Children)
                //{
                //    MessageBox.Show(item.GetType().Name);
                //}
                if (txtSliderValue != null)
                {
                    txtSliderValue.Text = slider1.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        */
    }
}
