using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace wpf_DataBinding.Converters
{
    public class ColorConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double salary = (double)value;
            if (salary > 4000)
                return Brushes.Red;
            else
                return Brushes.Wheat;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
