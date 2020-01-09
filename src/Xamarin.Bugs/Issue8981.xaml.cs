using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.Bugs
{
    public partial class Issue8981 : ContentPage
    {
        public Issue8981()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // todo: The label scale to 0 breaks the macOS app
            await TestLabel.ScaleTo(0, 1000);
            //await TestLabel.ScaleTo(0.0001, 1000); // this works

            await TestLabel.ScaleTo(1, 1000); // Do something to see that the app is not crashed
        }
    }
}
