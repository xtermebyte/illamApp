using System;
using System.Globalization;
using Xamarin.Forms;

namespace illam.Extensions
{
    public class ImageSoourceConvertor : IValueConverter
    {
        public string Param1
        {
            get;
            set;
        }
        public ImageSoourceConvertor()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;
            if (string.IsNullOrEmpty(source))
                return null;

            return ImageSource.FromFile("q6.PNG");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
