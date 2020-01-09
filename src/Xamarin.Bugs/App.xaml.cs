using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Bugs
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new Issue8981();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
