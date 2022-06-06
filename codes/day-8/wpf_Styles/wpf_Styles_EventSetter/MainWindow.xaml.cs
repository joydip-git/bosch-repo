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

namespace wpf_Styles_EventSetter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.OriginalSource is TextBlock)
            {
                (sender as TextBlock).Background = new SolidColorBrush(Colors.Beige);
            }
        }

        private void txtBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            if (e.OriginalSource is TextBlock)
            {
                (sender as TextBlock).Background = null;
            }
        }
    }
}
