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

namespace wpf_ResourcesBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ImageBrush imageBrush = new ImageBrush();
            //imageBrush.Viewport = new Rect(0, 0, 32, 32);
            //imageBrush.ViewportUnits = BrushMappingMode.Absolute;
            //imageBrush.ImageSource = "";
            //imageBrush.Opacity = 0.3;
            //this.Resources.Add("k1", new ImageBrush());
        }
    }
}
