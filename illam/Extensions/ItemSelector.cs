using System;
using Xamarin.Forms;

namespace illam.Extensions
{
    public class ItemSelector : DataTemplateSelector
    {
        public ItemSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return new DataTemplate(typeof(illam.Views.SampleListViewCell));
        }
    }
}
