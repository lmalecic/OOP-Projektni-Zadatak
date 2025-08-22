using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace App_WPF.Converters
{
    public class WinsLossesDrawsConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object? parameter, CultureInfo culture)
        {
            int ToInt(object? o)
            {
                if (o == null || o == DependencyProperty.UnsetValue) return 0;
                if (o is int i) return i;
                return int.TryParse(o.ToString(), out var v) ? v : 0;
            }

            var w = values.Length > 0 ? ToInt(values[0]) : 0;
            var l = values.Length > 1 ? ToInt(values[1]) : 0;
            var d = values.Length > 2 ? ToInt(values[2]) : 0;

            return $"{w}/{l}/{d}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object? parameter, CultureInfo culture)
        {
            return targetTypes.Select(_ => DependencyProperty.UnsetValue).ToArray();
        }
    }
}
