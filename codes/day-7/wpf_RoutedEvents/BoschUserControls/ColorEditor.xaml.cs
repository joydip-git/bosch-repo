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

namespace BoschUserControls
{
    /// <summary>
    /// Interaction logic for ColorEditor.xaml
    /// </summary>
    //public partial class ColorEditor : Control
    public partial class ColorEditor : UserControl
    {
        public static readonly DependencyProperty RedProperty;
        public static readonly DependencyProperty GreenProperty;
        public static readonly DependencyProperty BlueProperty;
        public static readonly DependencyProperty ColorProperty;

        public static readonly RoutedEvent ColorChangedEvent;

        static ColorEditor()
        {
            //RedProperty
            FrameworkPropertyMetadata redPropertyMetadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChangedCallback));
            RedProperty = DependencyProperty.Register("Red", typeof(byte), typeof(ColorEditor), redPropertyMetadata);          

            //GreenProperty
            FrameworkPropertyMetadata greenPropertyMetadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChangedCallback));
            GreenProperty = DependencyProperty.Register("Green", typeof(byte), typeof(ColorEditor), greenPropertyMetadata);

            //BlueProperty
            FrameworkPropertyMetadata bluePropertyMetadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChangedCallback));
            BlueProperty = DependencyProperty.Register("Blue", typeof(byte), typeof(ColorEditor), bluePropertyMetadata);

            //ColorProperty
            FrameworkPropertyMetadata colorPropertyMetadata = new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChangedCallback));
            ColorProperty = DependencyProperty.Register(
                "Color",
                typeof(Color),
                typeof(ColorEditor),
                colorPropertyMetadata
                );

            //ColorChangedEvent
            ColorChangedEvent = EventManager.RegisterRoutedEvent(
                "ColorChanged",
                RoutingStrategy.Bubble,
                typeof(RoutedPropertyChangedEventHandler<Color>),
                typeof(ColorEditor)
                );

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorEditor), new FrameworkPropertyMetadata(typeof(ColorEditor)));
        }
        public ColorEditor()
        {
            InitializeComponent();
        }

        private static void OnColorRGBChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ColorEditor cd = d as ColorEditor;
            Color color = cd.Color;

            if (e.Property == RedProperty)
            {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty)
            {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty)
            {
                color.B = (byte)e.NewValue;
            }

            cd.Color = color;
        }
        private static void OnColorChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Color color = (Color)e.NewValue;
            ColorEditor cd = d as ColorEditor;
            cd.Red = color.R;
            cd.Green = color.G;
            cd.Blue = color.B;

            RoutedPropertyChangedEventArgs<Color> args = new RoutedPropertyChangedEventArgs<Color>((Color)e.NewValue, (Color)e.OldValue);
            args.RoutedEvent = ColorEditor.ColorChangedEvent;
            cd.RaiseEvent(args);
        }

        public byte Red
        {
            get => (byte)this.GetValue(RedProperty);
            set => this.SetValue(RedProperty, value);
        }
        public byte Green
        {
            get => (byte)this.GetValue(GreenProperty);
            set => this.SetValue(GreenProperty, value);
        }
        public byte Blue
        {
            get => (byte)this.GetValue(BlueProperty);
            set => this.SetValue(BlueProperty, value);
        }
        public Color Color
        {
            get => (Color)this.GetValue(ColorProperty);
            set => this.SetValue(ColorProperty, value);
        }

        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { AddHandler(ColorChangedEvent, value); }
            remove { RemoveHandler(ColorChangedEvent, value); }
        }
    }
}
