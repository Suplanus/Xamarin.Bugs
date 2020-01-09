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

            await TestLabel.ScaleTo(0, 1000);
            await TestLabel.ScaleTo(1, 1000);
        }
    }
}
