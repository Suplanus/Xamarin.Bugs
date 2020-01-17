using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.Bugs
{
    public partial class Issue9241 : ContentPage
    {
        public Issue9241()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Clicked", "Clicked", "OK");
        }
    }
}
