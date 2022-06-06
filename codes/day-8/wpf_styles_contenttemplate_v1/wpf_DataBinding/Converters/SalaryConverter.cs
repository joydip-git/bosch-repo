using System;
using System.Globalization;
using System.Windows.Data;

namespace wpf_DataBinding.Converters
{
    public class SalaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double salary = (double)value;
            return salary.ToString("C", new CultureInfo("en-US"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string input = (string)value;
            double salary;
            return double.TryParse(input, NumberStyles.Any, null, out salary) ? salary : value;
        }
    }
}
