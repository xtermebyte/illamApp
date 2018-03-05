using System;
using illam.Models;
using Xamarin.Forms;

namespace illam.Views
{
    public class QuestionViewCell : ViewCell
    {
        public QuestionModel Context
        {
            get;
            set;
        }

        public QuestionViewCell()
        {
            Initialize();
        }

        private void Initialize()
        {
            //Add the image
            //Image img = new Image();
            //img.Source = ImageSource.FromUri(new Uri((string)GetValue(ImageURLProperty)));
            Label lb = new Label();
            lb.SetBinding(Label.TextProperty, "QuestionNumber");


            //Add a text box for answer
            Entry answerEntry = new Entry();

            View = new StackLayout
            {
                Children = { lb, answerEntry }
            };
        }
    }
}
