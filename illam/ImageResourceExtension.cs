using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace illam
{
    // You exclude the 'Extension' suffix when using in Xaml markup
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromFile(Source);

            return imageSource;
        }
    }
}
