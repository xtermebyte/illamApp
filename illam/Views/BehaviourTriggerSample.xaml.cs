using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace illam.Views
{
    public partial class BehaviourTriggerSample : ContentPage
    {
        public string ImageName
        {
            get;
            set;
        }

        public string initValue
        {
            get;
            set;
        }

        public BehaviourTriggerSample()
        {
            InitializeComponent();
            ImageName = "q3.PNG";
            initValue = "Yellow";

            this.BindingContext = this;

        }
    }
}
