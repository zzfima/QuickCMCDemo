using System;
using System.Globalization;
using System.Windows.Data;

namespace QuickCMCDemo.MVVMCross.Converters
{
    public class FrequencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
                return d.ToString("F3", culture) + " Hz";

            return value?.ToString() ?? string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(double) && double.TryParse(value?.ToString(), out double d))
                return d;

            return Binding.DoNothing;
        }
    }
}