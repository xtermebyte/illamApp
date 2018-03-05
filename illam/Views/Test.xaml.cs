using System;
using System.Collections.Generic;

using Xamarin.Forms;
using illam.Models;
using illam.Services;
using Xamarin.Forms.Xaml;

namespace illam.Views
{
    public partial class Test : ContentPage
    {
        public List<QuestionModel> data
        {
            get;
            set;
        }

        public string Title1
        {
            get;
            set;
        }

        public Test()
        {
            InitializeComponent();
            Initialize();
            //testimage.Source = ImageSource.FromUri(new Uri(@"https://2.img-dpreview.com/files/p/TS1200x900~sample_galleries/6974816295/0090248310.jpg"));
        }

        void Handle_RefreshClicked(object sender, System.EventArgs e)
        {
            data = GetQuestionList();
            this.BindingContext = null;
            this.BindingContext = this;
            //questionList.ItemsSource = null;
            //questionList.ItemsSource = data;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (pwd.Text == "1122")
            {
                foreach (var a in data)
                {
                    a.ShowAnswer = !a.ShowAnswer;
                    a.OnPropertyChanged("IsWrong");
                    a.OnPropertyChanged("IsCorrect");
                }


                //questionList.ItemsSource = null;
                //questionList.ItemsSource = data;
            }
        }

        void Handle_ClickedQuestion(object sender, System.EventArgs e)
        {
            var qdata = ((Button)sender).CommandParameter;
            QuestionModel question = (QuestionModel)qdata;
            question.Answer = ((Button)sender).Text;
            question.OnPropertyChanged("ColorA");
            question.OnPropertyChanged("ColorB");
            question.OnPropertyChanged("ColorC");
            question.OnPropertyChanged("ColorD");
            question.OnPropertyChanged("IsWrong");
            question.OnPropertyChanged("IsCorrect");
            //questionList.ItemsSource = null;
            //questionList.ItemsSource = data;
            //OnPropertyChanged("data");
        }

        private void Initialize()
        {
            //testImg.Source = ImageSource.FromFile(@"q4.png");
            data = GetQuestionList();
            Title1 = "Welcome";
            this.BindingContext = this;

            //questionList.ItemsSource = data;
            //questionList.ItemTemplate = new DataTemplate(typeof(QuestionViewCell));
        }

        private List<QuestionModel> GetQuestionList()
        {
            var retData = TestService.GetTest();

            //string fileUrl = "http://192.168.1.67/Images/Test1/";
            List<QuestionModel> ret = new List<QuestionModel>();

            foreach (var a in retData.Questions)
                ret.Add(new QuestionModel(Convert.ToInt32(a.QNo), a.ImageURL, retData.RightImage, retData.WrongImage, a.Answer ));

            return ret;
        }
    }

   /* // You exclude the 'Extension' suffix when using in Xaml markup
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
    }*/
}
