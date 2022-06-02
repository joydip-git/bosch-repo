using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace wpf_DependencyPropertySystem.CustomControls
{
    public class AppButton : Button
    {
        public static readonly DependencyProperty SetBackgroundRedProperty;

        static AppButton()
        {
            FrameworkPropertyMetadata propertyMetadata = new FrameworkPropertyMetadata(false, new PropertyChangedCallback(BackgroundColorChangedCallback));
            SetBackgroundRedProperty = DependencyProperty.Register("SetBackgroundRed", typeof(bool), typeof(AppButton), propertyMetadata);
        }
        private static void BackgroundColorChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as AppButton).Background = (bool)e.NewValue ? Brushes.Red : Brushes.Wheat;
        }
        public bool SetBackgroundRed
        {
            set => SetValue(SetBackgroundRedProperty, value);
            get => (bool)GetValue(SetBackgroundRedProperty);
        }
    }
}
