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
using System.Windows.Shapes;

namespace wpf_RoutedEvents
{
    /// <summary>
    /// Interaction logic for UsingColorEditor.xaml
    /// </summary>
    public partial class UsingColorEditor : Window
    {
        public UsingColorEditor()
        {
            InitializeComponent();
        }

        private void Grid_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            //if (txtColor != null)
                txtColor.Text = e.NewValue.ToString();
        }
    }
}
