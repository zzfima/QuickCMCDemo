using System;
using System.Globalization;
using System.Windows.Data;

namespace QuickCMCDemo.MVVMCross.Converters
{
    public class DecimalPlacesConverter : IValueConverter
    {
        public int DecimalPlaces { get; set; } = 2; // Default to 2

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
                return d.ToString($"F{DecimalPlaces}", culture);
            if (value is float f)
                return f.ToString($"F{DecimalPlaces}", culture);

            return value?.ToString() ?? string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(double) && double.TryParse(value?.ToString(), out double d))
                return d;
            if (targetType == typeof(float) && float.TryParse(value?.ToString(), out float f))
                return f;

            return Binding.DoNothing;
        }
    }
}