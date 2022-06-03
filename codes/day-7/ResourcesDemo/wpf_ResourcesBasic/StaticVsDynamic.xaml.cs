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

namespace wpf_ResourcesBasic
{
    /// <summary>
    /// Interaction logic for StaticVsDynamic.xaml
    /// </summary>
    public partial class StaticVsDynamic : Window
    {
        public StaticVsDynamic()
        {
            InitializeComponent();
        }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            //var brush = this.Resources["TileBrush"] as ImageBrush;
            //brush.Viewport = new Rect(0, 0, 5, 5);
            this.Resources["TileBrush"] = new SolidColorBrush(Colors.Wheat);

            var button = sender as Button;
            MessageBox.Show(button.TryFindResource("tileBrush")!=null? button.TryFindResource("tileBrush").GetType().Name:"Not found");
        }

        private void btnDynamic_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show(button.FindResource("tileBrush").GetType().Name);
        }
    }
}
