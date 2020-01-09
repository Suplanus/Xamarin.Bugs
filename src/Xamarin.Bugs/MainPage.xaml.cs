using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Bugs
{
    [DesignTimeVisible(false)]
    public partial class Issue8981 : ContentPage
    {
        public Issue8981()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            
        }
    }
}