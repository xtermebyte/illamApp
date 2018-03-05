using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace illam.Views
{
    public partial class Exercise : ContentPage
    {
        public Exercise()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BehaviourTriggerSample());
        }

        void Handle_ListClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListViewSample());
        }
    }
}
