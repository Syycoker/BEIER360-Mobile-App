using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BEIER360
{
    public partial class MainPage : ContentPage
    {
        private HomePage newHomePage = new HomePage();
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void Yes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutputPage());
        }

        private async void No_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OutputPageExt(newHomePage));
        }

    }
}
