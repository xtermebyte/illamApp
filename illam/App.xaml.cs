using illam.Views;
using Xamarin.Forms;

namespace illam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Test());
            MainPage = new NavigationPage(new ListViewSample());
            //MainPage = new NavigationPage(new Exercise());
            //Chcking
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
