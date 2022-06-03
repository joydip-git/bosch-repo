using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace wpf_RoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.Initialized <-- NOT a routed event
            
            
        }

        private void mainGrid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Button).Name);
            MessageBox.Show("handled by grid");
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Button).Name);
            MessageBox.Show("handled by outer button");            
        }

        private void btnInner_Click(object sender, RoutedEventArgs e)
        {            
            MessageBox.Show((e.OriginalSource as Button).Name);
            MessageBox.Show("handled by inner button");
            e.Handled = true;
        }
    }
}
