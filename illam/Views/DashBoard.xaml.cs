using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace illam.Views
{
    public partial class DashBoard : ContentPage
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Test());
        }

        void Handle_ExerciseClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Exercise());
        }
    }
}
