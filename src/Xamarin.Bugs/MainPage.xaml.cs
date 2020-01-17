using System.ComponentModel;
using Xamarin.Forms;

namespace Xamarin.Bugs
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Clicked", "Clicked", "OK");
        }
    }
}