using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEIER360
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutputPage : ContentPage
    {
        public OutputPage()
        {
            InitializeComponent();
        }

        private async void UserChange_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}