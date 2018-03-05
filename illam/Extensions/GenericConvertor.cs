using System;
using System.Globalization;
using Xamarin.Forms;

namespace illam.Extensions
{
    public class GenericConvertor<T> : IValueConverter
    {
        public T TrueValue { get; set; }
        public T FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (bool)value;
            if (data)
                return TrueValue;
            else
                return FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
